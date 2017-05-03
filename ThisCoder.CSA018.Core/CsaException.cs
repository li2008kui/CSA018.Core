using System;

namespace ThisCoder.CSA018.Core
{
    /// <summary>
    /// 表示发生错误时引发的 CSA018 异常。
    /// </summary>
    public class CsaException : Exception
    {
        /// <summary>
        /// 错误代码。
        /// <para><see cref="ErrorCode"/>类型，长度为4个字节。</para>
        /// </summary>
        public ErrorCode Code { get; private set; }

        /// <summary>
        /// 初始化 CsaException 类的新实例。
        /// </summary>
        /// <param name="code">
        /// 错误代码。
        /// <para><see cref="ErrorCode"/>类型，长度为4个字节。</para>
        /// </param>
        public CsaException(ErrorCode code = ErrorCode.Succeed)
            : base()
        {
            Code = code;
        }

        /// <summary>
        /// 使用指定错误消息初始化 CsaException 类的新实例。
        /// </summary>
        /// <param name="message">解释异常原因的错误信息。</param>
        /// <param name="code">
        /// 错误代码。
        /// <para><see cref="ErrorCode"/>类型，长度为4个字节。</para>
        /// </param>
        public CsaException(string message, ErrorCode code = ErrorCode.Succeed)
            : base(message)
        {
            Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the CsaException class with
        /// a specified error message and a reference to the inner exception that is
        /// the cause of this exception.
        /// </summary>
        /// <param name="message">解释异常原因的错误信息。</param>
        /// <param name="innerException">导致当前异常的异常。如果 innerException 参数不为空引用，则在处理内部异常的 catch 块中引发当前异常。</param>
        /// <param name="code">
        /// 错误代码。
        /// <para><see cref="ErrorCode"/>类型，长度为4个字节。</para>
        /// </param>
        public CsaException(string message, Exception innerException, ErrorCode code = ErrorCode.Succeed)
            : base(message, innerException)
        {
            Code = code;
        }
    }
}