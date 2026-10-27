using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200293E RID: 10558
	[UnrealObjectPath("/Script/UMG.BrushBinding")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UBrushBinding : UPropertyBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027100 RID: 160000 RVA: 0x003B935D File Offset: 0x003B755D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBrushBinding._ClassPtr;
		}

		// Token: 0x06027101 RID: 160001 RVA: 0x003B936C File Offset: 0x003B756C
		public UBrushBinding() : this(BuiltinUtils.AllocNativeUObject(UBrushBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027102 RID: 160002 RVA: 0x003B9394 File Offset: 0x003B7594
		[NullableContext(1)]
		public UBrushBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBrushBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027103 RID: 160003 RVA: 0x003B93C7 File Offset: 0x003B75C7
		[NullableContext(1)]
		public FSlateBrush GetValue()
		{
			return new FSlateBrush(UBrushBinding.__GetValue_Internal(base.NativePtr), null);
		}

		// Token: 0x06027104 RID: 160004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetValue_Internal(IntPtr @this);

		// Token: 0x06027105 RID: 160005 RVA: 0x003B93DA File Offset: 0x003B75DA
		static UBrushBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.BrushBinding");
		}

		// Token: 0x06027106 RID: 160006 RVA: 0x003B93E8 File Offset: 0x003B75E8
		protected UBrushBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015765 RID: 87909
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.BrushBinding";

		// Token: 0x04015766 RID: 87910
		private static IntPtr _ClassPtr;

		// Token: 0x04015767 RID: 87911
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
