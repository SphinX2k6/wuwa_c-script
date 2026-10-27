using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002945 RID: 10565
	[UnrealObjectPath("/Script/UMG.CheckedStateBinding")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UCheckedStateBinding : UPropertyBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060271C9 RID: 160201 RVA: 0x003BA288 File Offset: 0x003B8488
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCheckedStateBinding._ClassPtr;
		}

		// Token: 0x060271CA RID: 160202 RVA: 0x003BA294 File Offset: 0x003B8494
		public UCheckedStateBinding() : this(BuiltinUtils.AllocNativeUObject(UCheckedStateBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060271CB RID: 160203 RVA: 0x003BA2BC File Offset: 0x003B84BC
		[NullableContext(1)]
		public UCheckedStateBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCheckedStateBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060271CC RID: 160204 RVA: 0x003BA2EF File Offset: 0x003B84EF
		public ECheckBoxState GetValue()
		{
			return UCheckedStateBinding.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x060271CD RID: 160205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ECheckBoxState __GetValue_Internal(IntPtr @this);

		// Token: 0x060271CE RID: 160206 RVA: 0x003BA2FC File Offset: 0x003B84FC
		static UCheckedStateBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.CheckedStateBinding");
		}

		// Token: 0x060271CF RID: 160207 RVA: 0x003BA30A File Offset: 0x003B850A
		protected UCheckedStateBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157B1 RID: 87985
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.CheckedStateBinding";

		// Token: 0x040157B2 RID: 87986
		private static IntPtr _ClassPtr;

		// Token: 0x040157B3 RID: 87987
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
