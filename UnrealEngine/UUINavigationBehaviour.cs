using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002189 RID: 8585
	[UnrealObjectPath("/Script/LGUI.UINavigationBehaviour")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UUINavigationBehaviour : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060208A5 RID: 133285 RVA: 0x00303088 File Offset: 0x00301288
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUINavigationBehaviour._ClassPtr;
		}

		// Token: 0x060208A6 RID: 133286 RVA: 0x00303094 File Offset: 0x00301294
		public UUINavigationBehaviour() : this(BuiltinUtils.AllocNativeUObject(UUINavigationBehaviour.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060208A7 RID: 133287 RVA: 0x003030BC File Offset: 0x003012BC
		[NullableContext(1)]
		public UUINavigationBehaviour(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUINavigationBehaviour.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F42 RID: 32578
		// (get) Token: 0x060208A8 RID: 133288 RVA: 0x003030EF File Offset: 0x003012EF
		// (set) Token: 0x060208A9 RID: 133289 RVA: 0x003030FF File Offset: 0x003012FF
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

		// Token: 0x060208AA RID: 133290 RVA: 0x00303110 File Offset: 0x00301310
		public virtual void OnNotifyNotInteractiveBP()
		{
			UUINavigationBehaviour.__OnNotifyNotInteractiveBP_Internal(base.NativePtr);
		}

		// Token: 0x060208AB RID: 133291 RVA: 0x0030311D File Offset: 0x0030131D
		[NullableContext(2)]
		public virtual void OnNotifyNavigationSelectBP(ULGUIPointerEventData eventData)
		{
			UUINavigationBehaviour.__OnNotifyNavigationSelectBP_Internal(base.NativePtr, (eventData != null) ? eventData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060208AC RID: 133292 RVA: 0x0030313A File Offset: 0x0030133A
		[NullableContext(2)]
		public virtual void OnNotifyNavigationEnterBP(ULGUIPointerEventData eventData)
		{
			UUINavigationBehaviour.__OnNotifyNavigationEnterBP_Internal(base.NativePtr, (eventData != null) ? eventData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060208AD RID: 133293 RVA: 0x00303157 File Offset: 0x00301357
		public virtual void OnNotifyInteractiveBP()
		{
			UUINavigationBehaviour.__OnNotifyInteractiveBP_Internal(base.NativePtr);
		}

		// Token: 0x060208AE RID: 133294 RVA: 0x00303164 File Offset: 0x00301364
		public virtual bool OnCheckLoopScrollChangeNavigationBP()
		{
			return UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_Internal(base.NativePtr);
		}

		// Token: 0x060208AF RID: 133295 RVA: 0x00303171 File Offset: 0x00301371
		public virtual bool OnCheckCanSetNavigationBP()
		{
			return UUINavigationBehaviour.__OnCheckCanSetNavigationBP_Internal(base.NativePtr);
		}

		// Token: 0x060208B0 RID: 133296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNotifyNotInteractiveBP_Internal(IntPtr @this);

		// Token: 0x060208B1 RID: 133297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNotifyNavigationSelectBP_Internal(IntPtr @this, IntPtr eventData);

		// Token: 0x060208B2 RID: 133298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNotifyNavigationEnterBP_Internal(IntPtr @this, IntPtr eventData);

		// Token: 0x060208B3 RID: 133299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNotifyInteractiveBP_Internal(IntPtr @this);

		// Token: 0x060208B4 RID: 133300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnCheckLoopScrollChangeNavigationBP_Internal(IntPtr @this);

		// Token: 0x060208B5 RID: 133301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnCheckCanSetNavigationBP_Internal(IntPtr @this);

		// Token: 0x060208B6 RID: 133302 RVA: 0x0030317E File Offset: 0x0030137E
		static UUINavigationBehaviour()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UINavigationBehaviour");
		}

		// Token: 0x060208B7 RID: 133303 RVA: 0x0030318C File Offset: 0x0030138C
		protected UUINavigationBehaviour(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040116C6 RID: 71366
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UINavigationBehaviour";

		// Token: 0x040116C7 RID: 71367
		private static IntPtr _ClassPtr;

		// Token: 0x040116C8 RID: 71368
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040116C9 RID: 71369
		internal static int __PropertyOffset_LoopScrollViewGridIndex;

		// Token: 0x020034FC RID: 13564
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnNotifyNavigationSelectBP_FunctionParams
		{
			// Token: 0x04017522 RID: 95522
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x020034FD RID: 13565
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnNotifyNavigationEnterBP_FunctionParams
		{
			// Token: 0x04017523 RID: 95523
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x020034FE RID: 13566
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnCheckLoopScrollChangeNavigationBP_FunctionParams
		{
			// Token: 0x04017524 RID: 95524
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020034FF RID: 13567
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnCheckCanSetNavigationBP_FunctionParams
		{
			// Token: 0x04017525 RID: 95525
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
