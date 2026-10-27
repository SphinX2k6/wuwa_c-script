using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002136 RID: 8502
	[UnrealObjectPath("/Script/LGUI.UICustomDepthStencilMask")]
	[UnrealStructLayout(1776, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1776)]
	public class UUICustomDepthStencilMask : UUIPostProcessRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020021 RID: 131105 RVA: 0x002F99AF File Offset: 0x002F7BAF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUICustomDepthStencilMask._ClassPtr;
		}

		// Token: 0x06020022 RID: 131106 RVA: 0x002F99BC File Offset: 0x002F7BBC
		public UUICustomDepthStencilMask() : this(BuiltinUtils.AllocNativeUObject(UUICustomDepthStencilMask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020023 RID: 131107 RVA: 0x002F99E4 File Offset: 0x002F7BE4
		[NullableContext(1)]
		public UUICustomDepthStencilMask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUICustomDepthStencilMask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DC0 RID: 32192
		// (get) Token: 0x06020024 RID: 131108 RVA: 0x002F9A17 File Offset: 0x002F7C17
		// (set) Token: 0x06020025 RID: 131109 RVA: 0x002F9A27 File Offset: 0x002F7C27
		public unsafe bool bFullScreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUICustomDepthStencilMask.__PropertyOffset_bFullScreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUICustomDepthStencilMask.__PropertyOffset_bFullScreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007DC1 RID: 32193
		// (get) Token: 0x06020026 RID: 131110 RVA: 0x002F9A38 File Offset: 0x002F7C38
		// (set) Token: 0x06020027 RID: 131111 RVA: 0x002F9A48 File Offset: 0x002F7C48
		public unsafe EUICustomDepthStencilMaskSourceType sourceType
		{
			get
			{
				return (EUICustomDepthStencilMaskSourceType)(*(base.NativePtr + (IntPtr)UUICustomDepthStencilMask.__PropertyOffset_sourceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUICustomDepthStencilMask.__PropertyOffset_sourceType) = (byte)value;
			}
		}

		// Token: 0x17007DC2 RID: 32194
		// (get) Token: 0x06020028 RID: 131112 RVA: 0x002F9A59 File Offset: 0x002F7C59
		// (set) Token: 0x06020029 RID: 131113 RVA: 0x002F9A69 File Offset: 0x002F7C69
		public unsafe int stencilValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUICustomDepthStencilMask.__PropertyOffset_stencilValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUICustomDepthStencilMask.__PropertyOffset_stencilValue) = value;
			}
		}

		// Token: 0x0602002A RID: 131114 RVA: 0x002F9A7A File Offset: 0x002F7C7A
		public void SetStencilValue(int value)
		{
			UUICustomDepthStencilMask.__SetStencilValue_Internal(base.NativePtr, value);
		}

		// Token: 0x0602002B RID: 131115 RVA: 0x002F9A88 File Offset: 0x002F7C88
		public void SetSourceType(EUICustomDepthStencilMaskSourceType value)
		{
			UUICustomDepthStencilMask.__SetSourceType_Internal(base.NativePtr, value);
		}

		// Token: 0x0602002C RID: 131116 RVA: 0x002F9A96 File Offset: 0x002F7C96
		public void SetFullScreen(bool value)
		{
			UUICustomDepthStencilMask.__SetFullScreen_Internal(base.NativePtr, value);
		}

		// Token: 0x0602002D RID: 131117 RVA: 0x002F9AA4 File Offset: 0x002F7CA4
		public int GetStencilValue()
		{
			return UUICustomDepthStencilMask.__GetStencilValue_Internal(base.NativePtr);
		}

		// Token: 0x0602002E RID: 131118 RVA: 0x002F9AB1 File Offset: 0x002F7CB1
		public EUICustomDepthStencilMaskSourceType GetSourceType()
		{
			return UUICustomDepthStencilMask.__GetSourceType_Internal(base.NativePtr);
		}

		// Token: 0x0602002F RID: 131119 RVA: 0x002F9ABE File Offset: 0x002F7CBE
		public bool GetFullScreen()
		{
			return UUICustomDepthStencilMask.__GetFullScreen_Internal(base.NativePtr);
		}

		// Token: 0x06020030 RID: 131120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStencilValue_Internal(IntPtr @this, int value);

		// Token: 0x06020031 RID: 131121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSourceType_Internal(IntPtr @this, EUICustomDepthStencilMaskSourceType value);

		// Token: 0x06020032 RID: 131122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFullScreen_Internal(IntPtr @this, bool value);

		// Token: 0x06020033 RID: 131123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetStencilValue_Internal(IntPtr @this);

		// Token: 0x06020034 RID: 131124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUICustomDepthStencilMaskSourceType __GetSourceType_Internal(IntPtr @this);

		// Token: 0x06020035 RID: 131125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFullScreen_Internal(IntPtr @this);

		// Token: 0x06020036 RID: 131126 RVA: 0x002F9ACB File Offset: 0x002F7CCB
		static UUICustomDepthStencilMask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UICustomDepthStencilMask");
		}

		// Token: 0x06020037 RID: 131127 RVA: 0x002F9AD9 File Offset: 0x002F7CD9
		protected UUICustomDepthStencilMask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113BA RID: 70586
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UICustomDepthStencilMask";

		// Token: 0x040113BB RID: 70587
		private static IntPtr _ClassPtr;

		// Token: 0x040113BC RID: 70588
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113BD RID: 70589
		internal static int __PropertyOffset_bFullScreen;

		// Token: 0x040113BE RID: 70590
		internal static int __PropertyOffset_sourceType;

		// Token: 0x040113BF RID: 70591
		internal static int __PropertyOffset_stencilValue;
	}
}
