using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027C8 RID: 10184
	[UnrealObjectPath("/Script/SimplygonUObjects.OutputMaterialSettings")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FOutputMaterialSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025F7E RID: 155518 RVA: 0x00399226 File Offset: 0x00397426
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOutputMaterialSettings._ScriptStructPtr != 0) ? FOutputMaterialSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.OutputMaterialSettings", ref FOutputMaterialSettings._ScriptStructPtr);
		}

		// Token: 0x1700926D RID: 37485
		// (get) Token: 0x06025F7F RID: 155519 RVA: 0x0039924A File Offset: 0x0039744A
		// (set) Token: 0x06025F80 RID: 155520 RVA: 0x0039925A File Offset: 0x0039745A
		public unsafe int TextureWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOutputMaterialSettings.__PropertyOffset_TextureWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOutputMaterialSettings.__PropertyOffset_TextureWidth) = value;
			}
		}

		// Token: 0x1700926E RID: 37486
		// (get) Token: 0x06025F81 RID: 155521 RVA: 0x0039926B File Offset: 0x0039746B
		// (set) Token: 0x06025F82 RID: 155522 RVA: 0x0039927B File Offset: 0x0039747B
		public unsafe int TextureHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOutputMaterialSettings.__PropertyOffset_TextureHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOutputMaterialSettings.__PropertyOffset_TextureHeight) = value;
			}
		}

		// Token: 0x1700926F RID: 37487
		// (get) Token: 0x06025F83 RID: 155523 RVA: 0x0039928C File Offset: 0x0039748C
		// (set) Token: 0x06025F84 RID: 155524 RVA: 0x0039929C File Offset: 0x0039749C
		public unsafe int MultisamplingLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOutputMaterialSettings.__PropertyOffset_MultisamplingLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOutputMaterialSettings.__PropertyOffset_MultisamplingLevel) = value;
			}
		}

		// Token: 0x17009270 RID: 37488
		// (get) Token: 0x06025F85 RID: 155525 RVA: 0x003992AD File Offset: 0x003974AD
		// (set) Token: 0x06025F86 RID: 155526 RVA: 0x003992BD File Offset: 0x003974BD
		public unsafe int GutterSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOutputMaterialSettings.__PropertyOffset_GutterSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOutputMaterialSettings.__PropertyOffset_GutterSpace) = value;
			}
		}

		// Token: 0x06025F87 RID: 155527 RVA: 0x003992CE File Offset: 0x003974CE
		public FOutputMaterialSettings()
		{
		}

		// Token: 0x06025F88 RID: 155528 RVA: 0x003992D6 File Offset: 0x003974D6
		public FOutputMaterialSettings(int TextureWidth, int TextureHeight, int MultisamplingLevel, int GutterSpace)
		{
			this.TextureWidth = TextureWidth;
			this.TextureHeight = TextureHeight;
			this.MultisamplingLevel = MultisamplingLevel;
			this.GutterSpace = GutterSpace;
		}

		// Token: 0x06025F89 RID: 155529 RVA: 0x003992FB File Offset: 0x003974FB
		protected override IntPtr GetUStructPtr()
		{
			return FOutputMaterialSettings.StaticStruct();
		}

		// Token: 0x06025F8A RID: 155530 RVA: 0x00399307 File Offset: 0x00397507
		[NullableContext(2)]
		public FOutputMaterialSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025F8B RID: 155531 RVA: 0x00399311 File Offset: 0x00397511
		public FOutputMaterialSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025F8C RID: 155532 RVA: 0x0039931C File Offset: 0x0039751C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOutputMaterialSettings(Pointer, false, true);
		}

		// Token: 0x06025F8D RID: 155533 RVA: 0x00399326 File Offset: 0x00397526
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOutputMaterialSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014B9D RID: 84893
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SimplygonUObjects.OutputMaterialSettings";

		// Token: 0x04014B9E RID: 84894
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B9F RID: 84895
		internal static int __PropertyOffset_TextureWidth;

		// Token: 0x04014BA0 RID: 84896
		internal static int __PropertyOffset_TextureHeight;

		// Token: 0x04014BA1 RID: 84897
		internal static int __PropertyOffset_MultisamplingLevel;

		// Token: 0x04014BA2 RID: 84898
		internal static int __PropertyOffset_GutterSpace;
	}
}
