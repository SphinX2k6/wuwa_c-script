using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BC5 RID: 7109
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSplitTextureStreamer")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroSplitTextureStreamer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B475 RID: 111733 RVA: 0x00283281 File Offset: 0x00281481
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSplitTextureStreamer._ScriptStructPtr != 0) ? FKuroSplitTextureStreamer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSplitTextureStreamer", ref FKuroSplitTextureStreamer._ScriptStructPtr);
		}

		// Token: 0x17006D93 RID: 28051
		// (get) Token: 0x0601B476 RID: 111734 RVA: 0x002832A5 File Offset: 0x002814A5
		// (set) Token: 0x0601B477 RID: 111735 RVA: 0x002832B9 File Offset: 0x002814B9
		[Nullable(2)]
		public unsafe UKuroSplitTextureStreamerSettings Settings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSplitTextureStreamerSettings>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSplitTextureStreamer.__PropertyOffset_Settings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSplitTextureStreamer.__PropertyOffset_Settings, value);
			}
		}

		// Token: 0x17006D94 RID: 28052
		// (get) Token: 0x0601B478 RID: 111736 RVA: 0x002832D0 File Offset: 0x002814D0
		// (set) Token: 0x0601B479 RID: 111737 RVA: 0x00283313 File Offset: 0x00281513
		public TArray<UObject> StreamedTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._StreamedTextures) == null)
				{
					result = (this._StreamedTextures = new TArray<UObject>(base.NativePtr + (IntPtr)FKuroSplitTextureStreamer.__PropertyOffset_StreamedTextures, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StreamedTextures.CopyAssign(value);
			}
		}

		// Token: 0x0601B47A RID: 111738 RVA: 0x00283321 File Offset: 0x00281521
		public FKuroSplitTextureStreamer()
		{
		}

		// Token: 0x0601B47B RID: 111739 RVA: 0x00283329 File Offset: 0x00281529
		public FKuroSplitTextureStreamer(UKuroSplitTextureStreamerSettings Settings, TArray<UObject> StreamedTextures)
		{
			this.Settings = Settings;
			this.StreamedTextures = StreamedTextures;
		}

		// Token: 0x0601B47C RID: 111740 RVA: 0x0028333F File Offset: 0x0028153F
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSplitTextureStreamer.StaticStruct();
		}

		// Token: 0x0601B47D RID: 111741 RVA: 0x0028334B File Offset: 0x0028154B
		[NullableContext(2)]
		public FKuroSplitTextureStreamer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B47E RID: 111742 RVA: 0x00283355 File Offset: 0x00281555
		public FKuroSplitTextureStreamer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B47F RID: 111743 RVA: 0x00283360 File Offset: 0x00281560
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSplitTextureStreamer(Pointer, false, true);
		}

		// Token: 0x0601B480 RID: 111744 RVA: 0x0028336A File Offset: 0x0028156A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSplitTextureStreamer(Pointer, MemoryOwner);
		}

		// Token: 0x0400EB0D RID: 60173
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSplitTextureStreamer";

		// Token: 0x0400EB0E RID: 60174
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EB0F RID: 60175
		internal static int __PropertyOffset_Settings;

		// Token: 0x0400EB10 RID: 60176
		internal static int __PropertyOffset_StreamedTextures;

		// Token: 0x0400EB11 RID: 60177
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _StreamedTextures;
	}
}
