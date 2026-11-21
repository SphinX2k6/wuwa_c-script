using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000715 RID: 1813
	[UnrealObjectPath("/Script/LGUI.UINavigationBehaviour")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UUINavigationBehaviour : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C0B RID: 39947 RVA: 0x000E911C File Offset: 0x000E731C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUINavigationBehaviour._ClassPtr;
		}

		// Token: 0x06009C0C RID: 39948 RVA: 0x000E9128 File Offset: 0x000E7328
		public UUINavigationBehaviour() : this(BuiltinUtils.AllocNativeUObject(UUINavigationBehaviour.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C0D RID: 39949 RVA: 0x000E9150 File Offset: 0x000E7350
		[NullableContext(1)]
		public UUINavigationBehaviour(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUINavigationBehaviour.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06009C0E RID: 39950 RVA: 0x000E9183 File Offset: 0x000E7383
		// (set) Token: 0x06009C0F RID: 39951 RVA: 0x000E9193 File Offset: 0x000E7393
		public unsafe int LoopScrollViewGridIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationBehaviour.__PropertyOffset_LoopScrollViewGridIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationBehaviour.__PropertyOffset_LoopScrollViewGridIndex) = value;
			}
		}

		// Token: 0x06009C10 RID: 39952 RVA: 0x000E91A4 File Offset: 0x000E73A4
		public virtual void OnNotifyNotInteractiveBP()
		{
			UUINavigationBehaviour.__OnNotifyNotInteractiveBP_Internal(base.NativePtr);
		}

		// Token: 0x06009C11 RID: 39953 RVA: 0x000E91B1 File Offset: 0x000E73B1
		[NullableContext(2)]
		public virtual void OnNotifyNavigationSelectBP(ULGUIPointerEventData eventData)
		{
			UUINavigationBehaviour.__OnNotifyNavigationSelectBP_Internal(base.NativePtr, (eventData != null) ? eventData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009C12 RID: 39954 RVA: 0x000E91CE File Offset: 0x000E73CE
		[NullableContext(2)]
		public virtual void OnNotifyNavigationEnterBP(ULGUIPointerEventData eventData)
		{
			UUINavigationBehaviour.__OnNotifyNavigationEnterBP_Internal(base.NativePtr, (eventData != null) ? eventData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009C13 RID: 39955 RVA: 0x000E91EB File Offset: 0x000E73EB
		public virtual void OnNotifyInteractiveBP()
		{
			UUINavigationBehaviour.__OnNotifyInteractiveBP_Internal(base.NativePtr);
		}

		// Token: 0x06009C14 RID: 39956 RVA: 0x000E91F8 File Offset: 0x000E73F8
		public virtual bool OnCheckLoopScrollChangeNavigationBP()
		{
			return UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_Internal(base.NativePtr);
		}

		// Token: 0x06009C15 RID: 39957 RVA: 0x000E9205 File Offset: 0x000E7405
		public virtual bool OnCheckCanSetNavigationBP()
		{
			return UUINavigationBehaviour.__OnCheckCanSetNavigationBP_Internal(base.NativePtr);
		}

		// Token: 0x06009C16 RID: 39958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNotifyNotInteractiveBP_Internal(IntPtr @this);

		// Token: 0x06009C17 RID: 39959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNotifyNavigationSelectBP_Internal(IntPtr @this, IntPtr eventData);

		// Token: 0x06009C18 RID: 39960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNotifyNavigationEnterBP_Internal(IntPtr @this, IntPtr eventData);

		// Token: 0x06009C19 RID: 39961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNotifyInteractiveBP_Internal(IntPtr @this);

		// Token: 0x06009C1A RID: 39962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnCheckLoopScrollChangeNavigationBP_Internal(IntPtr @this);

		// Token: 0x06009C1B RID: 39963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnCheckCanSetNavigationBP_Internal(IntPtr @this);

		// Token: 0x06009C1C RID: 39964 RVA: 0x000E9212 File Offset: 0x000E7412
		static UUINavigationBehaviour()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UINavigationBehaviour");
		}

		// Token: 0x06009C1D RID: 39965 RVA: 0x000E9220 File Offset: 0x000E7420
		protected UUINavigationBehaviour(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004340 RID: 17216
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UINavigationBehaviour";

		// Token: 0x04004341 RID: 17217
		private static IntPtr _ClassPtr;

		// Token: 0x04004342 RID: 17218
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004343 RID: 17219
		internal static int __PropertyOffset_LoopScrollViewGridIndex;

		// Token: 0x02000F1D RID: 3869
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnNotifyNavigationSelectBP_FunctionParams
		{
			// Token: 0x040062ED RID: 25325
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x02000F1E RID: 3870
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnNotifyNavigationEnterBP_FunctionParams
		{
			// Token: 0x040062EE RID: 25326
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x02000F1F RID: 3871
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnCheckLoopScrollChangeNavigationBP_FunctionParams
		{
			// Token: 0x040062EF RID: 25327
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000F20 RID: 3872
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnCheckCanSetNavigationBP_FunctionParams
		{
			// Token: 0x040062F0 RID: 25328
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
