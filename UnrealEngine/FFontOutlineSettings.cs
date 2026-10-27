using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002818 RID: 10264
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SlateCore.FontOutlineSettings")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FFontOutlineSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602627B RID: 156283 RVA: 0x0039E6F4 File Offset: 0x0039C8F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFontOutlineSettings._ScriptStructPtr != 0) ? FFontOutlineSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.FontOutlineSettings", ref FFontOutlineSettings._ScriptStructPtr);
		}

		// Token: 0x1700934F RID: 37711
		// (get) Token: 0x0602627C RID: 156284 RVA: 0x0039E718 File Offset: 0x0039C918
		// (set) Token: 0x0602627D RID: 156285 RVA: 0x0039E728 File Offset: 0x0039C928
		public unsafe int OutlineSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontOutlineSettings.__PropertyOffset_OutlineSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontOutlineSettings.__PropertyOffset_OutlineSize) = value;
			}
		}

		// Token: 0x17009350 RID: 37712
		// (get) Token: 0x0602627E RID: 156286 RVA: 0x0039E739 File Offset: 0x0039C939
		// (set) Token: 0x0602627F RID: 156287 RVA: 0x0039E749 File Offset: 0x0039C949
		public unsafe bool bSeparateFillAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontOutlineSettings.__PropertyOffset_bSeparateFillAlpha) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontOutlineSettings.__PropertyOffset_bSeparateFillAlpha) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009351 RID: 37713
		// (get) Token: 0x06026280 RID: 156288 RVA: 0x0039E75A File Offset: 0x0039C95A
		// (set) Token: 0x06026281 RID: 156289 RVA: 0x0039E76A File Offset: 0x0039C96A
		public unsafe bool bApplyOutlineToDropShadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontOutlineSettings.__PropertyOffset_bApplyOutlineToDropShadows) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontOutlineSettings.__PropertyOffset_bApplyOutlineToDropShadows) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009352 RID: 37714
		// (get) Token: 0x06026282 RID: 156290 RVA: 0x0039E77B File Offset: 0x0039C97B
		// (set) Token: 0x06026283 RID: 156291 RVA: 0x0039E78F File Offset: 0x0039C98F
		[Nullable(2)]
		public unsafe UObject OutlineMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FFontOutlineSettings.__PropertyOffset_OutlineMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFontOutlineSettings.__PropertyOffset_OutlineMaterial, value);
			}
		}

		// Token: 0x17009353 RID: 37715
		// (get) Token: 0x06026284 RID: 156292 RVA: 0x0039E7A4 File Offset: 0x0039C9A4
		// (set) Token: 0x06026285 RID: 156293 RVA: 0x0039E7B8 File Offset: 0x0039C9B8
		public unsafe FLinearColor OutlineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontOutlineSettings.__PropertyOffset_OutlineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontOutlineSettings.__PropertyOffset_OutlineColor) = value;
			}
		}

		// Token: 0x06026286 RID: 156294 RVA: 0x0039E7CD File Offset: 0x0039C9CD
		public FFontOutlineSettings()
		{
		}

		// Token: 0x06026287 RID: 156295 RVA: 0x0039E7D5 File Offset: 0x0039C9D5
		[NullableContext(1)]
		public FFontOutlineSettings(int OutlineSize, bool bSeparateFillAlpha, bool bApplyOutlineToDropShadows, UObject OutlineMaterial, FLinearColor OutlineColor)
		{
			this.OutlineSize = OutlineSize;
			this.bSeparateFillAlpha = bSeparateFillAlpha;
			this.bApplyOutlineToDropShadows = bApplyOutlineToDropShadows;
			this.OutlineMaterial = OutlineMaterial;
			this.OutlineColor = OutlineColor;
		}

		// Token: 0x06026288 RID: 156296 RVA: 0x0039E802 File Offset: 0x0039CA02
		protected override IntPtr GetUStructPtr()
		{
			return FFontOutlineSettings.StaticStruct();
		}

		// Token: 0x06026289 RID: 156297 RVA: 0x0039E80E File Offset: 0x0039CA0E
		[NullableContext(2)]
		public FFontOutlineSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602628A RID: 156298 RVA: 0x0039E818 File Offset: 0x0039CA18
		public FFontOutlineSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602628B RID: 156299 RVA: 0x0039E823 File Offset: 0x0039CA23
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFontOutlineSettings(Pointer, false, true);
		}

		// Token: 0x0602628C RID: 156300 RVA: 0x0039E82D File Offset: 0x0039CA2D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFontOutlineSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014E2A RID: 85546
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.FontOutlineSettings";

		// Token: 0x04014E2B RID: 85547
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E2C RID: 85548
		internal static int __PropertyOffset_OutlineSize;

		// Token: 0x04014E2D RID: 85549
		internal static int __PropertyOffset_bSeparateFillAlpha;

		// Token: 0x04014E2E RID: 85550
		internal static int __PropertyOffset_bApplyOutlineToDropShadows;

		// Token: 0x04014E2F RID: 85551
		internal static int __PropertyOffset_OutlineMaterial;

		// Token: 0x04014E30 RID: 85552
		internal static int __PropertyOffset_OutlineColor;
	}
}
