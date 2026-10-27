using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002816 RID: 10262
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SlateCore.FontData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FFontData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026268 RID: 156264 RVA: 0x0039E5B2 File Offset: 0x0039C7B2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFontData._ScriptStructPtr != 0) ? FFontData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.FontData", ref FFontData._ScriptStructPtr);
		}

		// Token: 0x1700934A RID: 37706
		// (get) Token: 0x06026269 RID: 156265 RVA: 0x0039E5D6 File Offset: 0x0039C7D6
		// (set) Token: 0x0602626A RID: 156266 RVA: 0x0039E5EA File Offset: 0x0039C7EA
		public unsafe string FontFilename
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFontData.__PropertyOffset_FontFilename)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFontData.__PropertyOffset_FontFilename)), value);
			}
		}

		// Token: 0x1700934B RID: 37707
		// (get) Token: 0x0602626B RID: 156267 RVA: 0x0039E5FF File Offset: 0x0039C7FF
		// (set) Token: 0x0602626C RID: 156268 RVA: 0x0039E60F File Offset: 0x0039C80F
		public unsafe EFontHinting Hinting
		{
			get
			{
				return (EFontHinting)(*(base.NativePtr + (IntPtr)FFontData.__PropertyOffset_Hinting));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontData.__PropertyOffset_Hinting) = (byte)value;
			}
		}

		// Token: 0x1700934C RID: 37708
		// (get) Token: 0x0602626D RID: 156269 RVA: 0x0039E620 File Offset: 0x0039C820
		// (set) Token: 0x0602626E RID: 156270 RVA: 0x0039E630 File Offset: 0x0039C830
		public unsafe EFontLoadingPolicy LoadingPolicy
		{
			get
			{
				return (EFontLoadingPolicy)(*(base.NativePtr + (IntPtr)FFontData.__PropertyOffset_LoadingPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontData.__PropertyOffset_LoadingPolicy) = (byte)value;
			}
		}

		// Token: 0x1700934D RID: 37709
		// (get) Token: 0x0602626F RID: 156271 RVA: 0x0039E641 File Offset: 0x0039C841
		// (set) Token: 0x06026270 RID: 156272 RVA: 0x0039E651 File Offset: 0x0039C851
		public unsafe int SubFaceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontData.__PropertyOffset_SubFaceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontData.__PropertyOffset_SubFaceIndex) = value;
			}
		}

		// Token: 0x1700934E RID: 37710
		// (get) Token: 0x06026271 RID: 156273 RVA: 0x0039E662 File Offset: 0x0039C862
		// (set) Token: 0x06026272 RID: 156274 RVA: 0x0039E676 File Offset: 0x0039C876
		[Nullable(2)]
		public unsafe UObject FontFaceAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FFontData.__PropertyOffset_FontFaceAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFontData.__PropertyOffset_FontFaceAsset, value);
			}
		}

		// Token: 0x06026273 RID: 156275 RVA: 0x0039E68B File Offset: 0x0039C88B
		public FFontData()
		{
		}

		// Token: 0x06026274 RID: 156276 RVA: 0x0039E693 File Offset: 0x0039C893
		public FFontData(string FontFilename, EFontHinting Hinting, EFontLoadingPolicy LoadingPolicy, int SubFaceIndex, UObject FontFaceAsset, UFontBulkData BulkDataPtr_DEPRECATED, TArray<byte> FontData_DEPRECATED)
		{
			this.FontFilename = FontFilename;
			this.Hinting = Hinting;
			this.LoadingPolicy = LoadingPolicy;
			this.SubFaceIndex = SubFaceIndex;
			this.FontFaceAsset = FontFaceAsset;
		}

		// Token: 0x06026275 RID: 156277 RVA: 0x0039E6C0 File Offset: 0x0039C8C0
		protected override IntPtr GetUStructPtr()
		{
			return FFontData.StaticStruct();
		}

		// Token: 0x06026276 RID: 156278 RVA: 0x0039E6CC File Offset: 0x0039C8CC
		[NullableContext(2)]
		public FFontData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026277 RID: 156279 RVA: 0x0039E6D6 File Offset: 0x0039C8D6
		public FFontData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026278 RID: 156280 RVA: 0x0039E6E1 File Offset: 0x0039C8E1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFontData(Pointer, false, true);
		}

		// Token: 0x06026279 RID: 156281 RVA: 0x0039E6EB File Offset: 0x0039C8EB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFontData(Pointer, MemoryOwner);
		}

		// Token: 0x04014E22 RID: 85538
		public const string __ObjectPath = "/Script/SlateCore.FontData";

		// Token: 0x04014E23 RID: 85539
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E24 RID: 85540
		internal static int __PropertyOffset_FontFilename;

		// Token: 0x04014E25 RID: 85541
		internal static int __PropertyOffset_Hinting;

		// Token: 0x04014E26 RID: 85542
		internal static int __PropertyOffset_LoadingPolicy;

		// Token: 0x04014E27 RID: 85543
		internal static int __PropertyOffset_SubFaceIndex;

		// Token: 0x04014E28 RID: 85544
		internal static int __PropertyOffset_FontFaceAsset;
	}
}
