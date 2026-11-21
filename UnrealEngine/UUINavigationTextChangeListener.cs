using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000717 RID: 1815
	[UnrealObjectPath("/Script/LGUI.UINavigationTextChangeListener")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UUINavigationTextChangeListener : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C1E RID: 39966 RVA: 0x000E9229 File Offset: 0x000E7429
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUINavigationTextChangeListener._ClassPtr;
		}

		// Token: 0x06009C1F RID: 39967 RVA: 0x000E9238 File Offset: 0x000E7438
		public UUINavigationTextChangeListener() : this(BuiltinUtils.AllocNativeUObject(UUINavigationTextChangeListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C20 RID: 39968 RVA: 0x000E9260 File Offset: 0x000E7460
		[NullableContext(1)]
		public UUINavigationTextChangeListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUINavigationTextChangeListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06009C21 RID: 39969 RVA: 0x000E9293 File Offset: 0x000E7493
		// (set) Token: 0x06009C22 RID: 39970 RVA: 0x000E92A7 File Offset: 0x000E74A7
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

		// Token: 0x06009C23 RID: 39971 RVA: 0x000E92BC File Offset: 0x000E74BC
		[NullableContext(1)]
		public unsafe virtual void OnNotifyTextChangeBP(string NotifyText)
		{
			FString fstring = FString.AllocTemp(NotifyText);
			UUINavigationTextChangeListener.__OnNotifyTextChangeBP_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009C24 RID: 39972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNotifyTextChangeBP_Internal(IntPtr @this, in FString NotifyText);

		// Token: 0x06009C25 RID: 39973 RVA: 0x000E92E6 File Offset: 0x000E74E6
		static UUINavigationTextChangeListener()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UINavigationTextChangeListener");
		}

		// Token: 0x06009C26 RID: 39974 RVA: 0x000E92F4 File Offset: 0x000E74F4
		protected UUINavigationTextChangeListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400434B RID: 17227
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UINavigationTextChangeListener";

		// Token: 0x0400434C RID: 17228
		private static IntPtr _ClassPtr;

		// Token: 0x0400434D RID: 17229
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400434E RID: 17230
		internal static int __PropertyOffset_TextActor;

		// Token: 0x02000F21 RID: 3873
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnNotifyTextChangeBP_FunctionParams
		{
			// Token: 0x040062F1 RID: 25329
			[FieldOffset(0)]
			public FString NotifyText;
		}
	}
}
