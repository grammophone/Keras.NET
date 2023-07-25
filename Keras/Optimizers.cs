﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Keras.Optimizers
{
    /// <summary>
    /// Stochastic gradient descent optimizer.    Includes support for momentum, learning rate decay, and Nesterov momentum.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class SGD : Base
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SGD"/> class.
        /// </summary>
        /// <param name="learning_rate">float >= 0. Learning rate.</param>
        /// <param name="momentum">float >= 0. Parameter that accelerates SGD in the relevant direction and dampens oscillations.</param>
        /// <param name="decay"> float >= 0. Learning rate decay over each update.</param>
        /// <param name="nesterov">boolean. Whether to apply Nesterov momentum.</param>
        public SGD(float learning_rate = 0.01f, float momentum = 0.0f, float decay = 0.0f, bool nesterov = false)
        {
            Parameters["learning_rate"] = learning_rate;
            Parameters["momentum"] = momentum;
            Parameters["decay"] = decay;
            Parameters["nesterov"] = nesterov;

            PyInstance = Instance.keras.optimizers.SGD;
            Init();
        }
    }

    /// <summary>
    /// RMSProp optimizer.    It is recommended to leave the parameters of this optimizer at their default values (except the learning rate, which can be freely tuned).
    /// This optimizer is usually a good choice for recurrent neural networks.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class RMSprop : Base
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RMSprop"/> class.
        /// </summary>
        /// <param name="learning_rate">float >= 0. Learning rate.</param>
        /// <param name="rho">The rho factor. float > 0</param>
        /// <param name="epsilon">float >= 0. Fuzz factor. If None, defaults to K.epsilon().</param>
        /// <param name="decay">float >= 0. Learning rate decay over each update.</param>
        public RMSprop(float learning_rate = 0.01f, float rho = 0.9f, float? epsilon = null, float decay = 0.0f)
        {
            Parameters["learning_rate"] = learning_rate;
            Parameters["rho"] = rho;
            Parameters["epsilon"] = epsilon;
            Parameters["decay"] = decay;

            PyInstance = Instance.keras.optimizers.RMSprop;
            Init();
        }
    }

    /// <summary>
    /// Adagrad is an optimizer with parameter-specific learning rates, which are adapted relative to how frequently a parameter gets updated during training. The more updates a parameter receives, the smaller the learning rate.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Adagrad : Base
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Adagrad"/> class.
        /// </summary>
        /// <param name="learning_rate">float >= 0. Initial learning rate.</param>
        /// <param name="epsilon">float >= 0. If None, defaults to K.epsilon().</param>
        /// <param name="decay">float >= 0. Learning rate decay over each update..</param>
        public Adagrad(float learning_rate = 0.01f, float? epsilon = null, float decay = 0.0f)
        {
            Parameters["learning_rate"] = learning_rate;
            Parameters["epsilon"] = epsilon;
            Parameters["decay"] = decay;

            PyInstance = Instance.keras.optimizers.Adagrad;
            Init();
        }
    }

    /// <summary>
    /// Adadelta is a more robust extension of Adagrad that adapts learning rates based on a moving window of gradient updates, instead of accumulating all past gradients. This way, Adadelta continues learning even when many updates have been done. Compared to Adagrad, in the original version of Adadelta you don't have to set an initial learning rate. In this version, initial learning rate and decay factor can be set, as in most other Keras optimizers.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Adadelta : Base
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Adadelta"/> class.
        /// </summary>
        /// <param name="learning_rate">float >= 0. Initial learning rate, defaults to 1. It is recommended to leave it at the default value.</param>
        /// <param name="rho">float >= 0. Adadelta decay factor, corresponding to fraction of gradient to keep at each time step.</param>
        /// <param name="epsilon">float >= 0. Fuzz factor. If None, defaults to K.epsilon().</param>
        /// <param name="decay">float >= 0. Initial learning rate decay.</param>
        public Adadelta(float learning_rate = 1.0f, float rho = 0.95f, float? epsilon = null, float decay = 0.0f)
        {
            Parameters["learning_rate"] = learning_rate;
            Parameters["rho"] = rho;
            Parameters["epsilon"] = epsilon;
            Parameters["decay"] = decay;

            PyInstance = Instance.keras.optimizers.Adadelta;
            Init();
        }
    }

    /// <summary>
    /// Adam optimizer. Default parameters follow those provided in the original paper.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Adam : Base
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Adam"/> class.
        /// </summary>
        /// <param name="learning_rate">The learning rate.</param>
        /// <param name="beta_1">The beta 1.</param>
        /// <param name="beta_2">The beta 2.</param>
        /// <param name="epsilon">The epsilon.</param>
        /// <param name="decay">The decay.</param>
        /// <param name="amsgrad">boolean. Whether to apply the AMSGrad variant of this algorithm from the paper "On the Convergence of Adam and Beyond".</param>
        public Adam(float learning_rate = 0.001f, float beta_1= 0.9f, float beta_2= 0.999f, float? epsilon = null, float decay = 0.0f, bool amsgrad = false)
        {
            Parameters["learning_rate"] = learning_rate;
            Parameters["beta_1"] = beta_1;
            Parameters["beta_2"] = beta_2;
            Parameters["epsilon"] = epsilon;
            Parameters["decay"] = decay;
            Parameters["amsgrad"] = amsgrad;

            PyInstance = Instance.keras.optimizers.Adam;
            Init();
        }
    }

    /// <summary>
    /// Adamax optimizer from Adam paper's Section 7. It is a variant of Adam based on the infinity norm.Default parameters follow those provided in the paper.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Adamax : Base
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Adamax"/> class.
        /// </summary>
        /// <param name="learning_rate">float >= 0. Learning rate.</param>
        /// <param name="beta_1">floats, 0 < beta < 1. Generally close to 1.</param>
        /// <param name="beta_2">floats, 0 < beta < 1. Generally close to 1.</param>
        /// <param name="epsilon">float >= 0. Fuzz factor. If None, defaults to K.epsilon().</param>
        /// <param name="decay">float >= 0. Learning rate decay over each update.</param>
        public Adamax(float learning_rate = 0.002f, float beta_1 = 0.9f, float beta_2 = 0.999f, float? epsilon = null, float decay = 0.0f)
        {
            Parameters["learning_rate"] = learning_rate;
            Parameters["beta_1"] = beta_1;
            Parameters["beta_2"] = beta_2;
            Parameters["epsilon"] = epsilon;
            Parameters["decay"] = decay;

            PyInstance = Instance.keras.optimizers.Adamax;
            Init();
        }
    }

    /// <summary>
    /// Nesterov Adam optimizer.    Much like Adam is essentially RMSprop with momentum, Nadam is Adam RMSprop with Nesterov momentum.
    /// Default parameters follow those provided in the paper.It is recommended to leave the parameters of this optimizer at their default values.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Nadam : Base
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Nadam"/> class.
        /// </summary>
        /// <param name="learning_rate">float >= 0. Learning rate.</param>
        /// <param name="beta_1">floats, 0 < beta < 1. Generally close to 1.</param>
        /// <param name="beta_2">floats, 0 < beta < 1. Generally close to 1.</param>
        /// <param name="epsilon">float >= 0. Fuzz factor. If None, defaults to K.epsilon().</param>
        /// <param name="schedule_decay">floats, 0 < schedule_decay < 1.</param>
        public Nadam(float learning_rate = 0.002f, float beta_1 = 0.9f, float beta_2 = 0.999f)
        {
            Parameters["learning_rate"] = learning_rate;
            Parameters["beta_1"] = beta_1;
            Parameters["beta_2"] = beta_2;

            PyInstance = Instance.keras.optimizers.Adamax;
            Init();
        }
    }
}
