using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Bulitin.Utils
{
	// Token: 0x02002AE8 RID: 10984
	[NullableContext(1)]
	[Nullable(0)]
	public static class TypeUtils
	{
		// Token: 0x06028418 RID: 164888 RVA: 0x003D3BAC File Offset: 0x003D1DAC
		public static object CreateTArray(Type InnerType, IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove)
		{
			return Activator.CreateInstance(typeof(TArray<>).MakeGenericType(new Type[]
			{
				InnerType
			}), new object[]
			{
				NativePtr,
				bWithMoveAssign,
				bWithCopyAssignIfCannotMove
			});
		}

		// Token: 0x06028419 RID: 164889 RVA: 0x003D3BF8 File Offset: 0x003D1DF8
		public static object CreateTSet(Type InnerType, IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove)
		{
			return Activator.CreateInstance(typeof(TSet<>).MakeGenericType(new Type[]
			{
				InnerType
			}), new object[]
			{
				NativePtr,
				bWithMoveAssign,
				bWithCopyAssignIfCannotMove
			});
		}

		// Token: 0x0602841A RID: 164890 RVA: 0x003D3C44 File Offset: 0x003D1E44
		public static object CreateTMap(Type KeyInnerType, Type ValueInnerType, IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove)
		{
			return Activator.CreateInstance(typeof(TMap<, >).MakeGenericType(new Type[]
			{
				KeyInnerType,
				ValueInnerType
			}), new object[]
			{
				NativePtr,
				bWithMoveAssign,
				bWithCopyAssignIfCannotMove
			});
		}
	}
}
