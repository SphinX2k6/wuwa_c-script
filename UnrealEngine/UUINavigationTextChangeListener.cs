using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200218D RID: 8589
	[UnrealObjectPath("/Script/LGUI.UINavigationTextChangeListener")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UUINavigationTextChangeListener : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060208ED RID: 133357 RVA: 0x00303522 File Offset: 0x00301722
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUINavigationTextChangeListener._ClassPtr;
		}

		// Token: 0x060208EE RID: 133358 RVA: 0x00303530 File Offset: 0x00301730
		public UUINavigationTextChangeListener() : this(BuiltinUtils.AllocNativeUObject(UUINavigationTextChangeListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060208EF RID: 133359 RVA: 0x00303558 File Offset: 0x00301758
		[NullableContext(1)]
		public UUINavigationTextChangeListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUINavigationTextChangeListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F55 RID: 32597
		// (get) Token: 0x060208F0 RID: 133360 RVA: 0x0030358B File Offset: 0x0030178B
		// (set) Token: 0x060208F1 RID: 133361 RVA: 0x0030359F File Offset: 0x0030179F
		[Nullable(2)]
		public unsafe AActor TextActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UUINavigationTextChangeListener.__PropertyOffset_TextActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUINavigationTextChangeListener.__PropertyOffset_TextActor, value);
			}
		}

		// Token: 0x060208F2 RID: 133362 RVA: 0x003035B4 File Offset: 0x003017B4
		[NullableContext(1)]
		public unsafe virtual void OnNotifyTextChangeBP(string NotifyText)
		{
			FString fstring = FString.AllocTemp(NotifyText);
			UUINavigationTextChangeListener.__OnNotifyTextChangeBP_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060208F3 RID: 133363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNotifyTextChangeBP_Internal(IntPtr @this, in FString NotifyText);

		// Token: 0x060208F4 RID: 133364 RVA: 0x003035DE File Offset: 0x003017DE
		static UUINavigationTextChangeListener()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UINavigationTextChangeListener");
		}

		// Token: 0x060208F5 RID: 133365 RVA: 0x003035EC File Offset: 0x003017EC
		protected UUINavigationTextChangeListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040116EE RID: 71406
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UINavigationTextChangeListener";

		// Token: 0x040116EF RID: 71407
		private static IntPtr _ClassPtr;

		// Token: 0x040116F0 RID: 71408
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040116F1 RID: 71409
		internal static int __PropertyOffset_TextActor;

		// Token: 0x02003500 RID: 13568
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnNotifyTextChangeBP_FunctionParams
		{
			// Token: 0x04017526 RID: 95526
			[FieldOffset(0)]
			public FString NotifyText;
		}
	}
}
