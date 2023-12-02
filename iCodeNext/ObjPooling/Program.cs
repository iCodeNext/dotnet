using Microsoft.Extensions.ObjectPool;
using System.Text;
using System.Xml.Linq;
namespace ObjPool;

 
    public class BufferConsumer(ObjectPool<ReusableBuffer> bufferPool)
    {
        public void DoSomething()
        {
            var buffer = bufferPool.Get();
            try
            {
               // TODO
            }
            finally
            {
                bufferPool.Return(buffer);
            }
        }
    }

        public class ReusableBuffer : IResettable
        {
            public bool TryReset()
            {
                // Reset State before it is returned to the pool.
                return true;
            }
        }


