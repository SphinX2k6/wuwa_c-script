using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012BD RID: 4797
	[UnrealObjectPath("/Script/FieldSystemEngine.ReturnResultsTerminal")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UReturnResultsTerminal : UFieldNodeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601190E RID: 71950 RVA: 0x0019C4DA File Offset: 0x0019A6DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReturnResultsTerminal._ClassPtr;
		}

		// Token: 0x0601190F RID: 71951 RVA: 0x0019C4E8 File Offset: 0x0019A6E8
		public UReturnResultsTerminal() : this(BuiltinUtils.AllocNativeUObject(UReturnResultsTerminal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011910 RID: 71952 RVA: 0x0019C510 File Offset: 0x0019A710
		[NullableContext(1)]
		public UReturnResultsTerminal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UReturnResultsTerminal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011911 RID: 71953 RVA: 0x0019C543 File Offset: 0x0019A743
		[NullableContext(2)]
		public UReturnResultsTerminal SetReturnResultsTerminal()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UReturnResultsTerminal>(UReturnResultsTerminal.__SetReturnResultsTerminal_Internal(base.NativePtr));
		}

		// Token: 0x06011912 RID: 71954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetReturnResultsTerminal_Internal(IntPtr @this);

		// Token: 0x06011913 RID: 71955 RVA: 0x0019C555 File Offset: 0x0019A755
		static UReturnResultsTerminal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.ReturnResultsTerminal");
		}

		// Token: 0x06011914 RID: 71956 RVA: 0x0019C563 File Offset: 0x0019A763
		protected UReturnResultsTerminal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009689 RID: 38537
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.ReturnResultsTerminal";

		// Token: 0x0400968A RID: 38538
		private static IntPtr _ClassPtr;

		// Token: 0x0400968B RID: 38539
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
