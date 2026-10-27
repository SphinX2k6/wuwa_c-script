using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029F3 RID: 10739
	[UnrealObjectPath("/Script/UMG.VisibilityBinding")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UVisibilityBinding : UPropertyBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027D43 RID: 163139 RVA: 0x003CAF8F File Offset: 0x003C918F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVisibilityBinding._ClassPtr;
		}

		// Token: 0x06027D44 RID: 163140 RVA: 0x003CAF9C File Offset: 0x003C919C
		public UVisibilityBinding() : this(BuiltinUtils.AllocNativeUObject(UVisibilityBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027D45 RID: 163141 RVA: 0x003CAFC4 File Offset: 0x003C91C4
		[NullableContext(1)]
		public UVisibilityBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVisibilityBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027D46 RID: 163142 RVA: 0x003CAFF7 File Offset: 0x003C91F7
		public ESlateVisibility GetValue()
		{
			return UVisibilityBinding.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x06027D47 RID: 163143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ESlateVisibility __GetValue_Internal(IntPtr @this);

		// Token: 0x06027D48 RID: 163144 RVA: 0x003CB004 File Offset: 0x003C9204
		static UVisibilityBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.VisibilityBinding");
		}

		// Token: 0x06027D49 RID: 163145 RVA: 0x003CB012 File Offset: 0x003C9212
		protected UVisibilityBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C74 RID: 89204
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.VisibilityBinding";

		// Token: 0x04015C75 RID: 89205
		private static IntPtr _ClassPtr;

		// Token: 0x04015C76 RID: 89206
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
