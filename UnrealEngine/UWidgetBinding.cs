using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029FC RID: 10748
	[UnrealObjectPath("/Script/UMG.WidgetBinding")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UWidgetBinding : UPropertyBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027E2F RID: 163375 RVA: 0x003CC40E File Offset: 0x003CA60E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetBinding._ClassPtr;
		}

		// Token: 0x06027E30 RID: 163376 RVA: 0x003CC41C File Offset: 0x003CA61C
		public UWidgetBinding() : this(BuiltinUtils.AllocNativeUObject(UWidgetBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027E31 RID: 163377 RVA: 0x003CC444 File Offset: 0x003CA644
		[NullableContext(1)]
		public UWidgetBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027E32 RID: 163378 RVA: 0x003CC477 File Offset: 0x003CA677
		[NullableContext(2)]
		public UWidget GetValue()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(UWidgetBinding.__GetValue_Internal(base.NativePtr));
		}

		// Token: 0x06027E33 RID: 163379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetValue_Internal(IntPtr @this);

		// Token: 0x06027E34 RID: 163380 RVA: 0x003CC489 File Offset: 0x003CA689
		static UWidgetBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetBinding");
		}

		// Token: 0x06027E35 RID: 163381 RVA: 0x003CC497 File Offset: 0x003CA697
		protected UWidgetBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CD4 RID: 89300
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetBinding";

		// Token: 0x04015CD5 RID: 89301
		private static IntPtr _ClassPtr;

		// Token: 0x04015CD6 RID: 89302
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
