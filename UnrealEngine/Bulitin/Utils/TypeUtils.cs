using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Bulitin.Utils
{
	// Token: 0x02000897 RID: 2199
	[NullableContext(1)]
	[Nullable(0)]
	public static class TypeUtils
	{
		// Token: 0x0600BDCD RID: 48589 RVA: 0x0012EEBC File Offset: 0x0012D0BC
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

		// Token: 0x0600BDCE RID: 48590 RVA: 0x0012EF08 File Offset: 0x0012D108
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

		// Token: 0x0600BDCF RID: 48591 RVA: 0x0012EF54 File Offset: 0x0012D154
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
