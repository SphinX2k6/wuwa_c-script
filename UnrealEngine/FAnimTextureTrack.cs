using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000848 RID: 2120
	[UnrealObjectPath("/Script/Engine.AnimTextureTrack")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FAnimTextureTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007231 RID: 29233 RVA: 0x000A37AC File Offset: 0x000A19AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimTextureTrack._ScriptStructPtr != 0) ? FAnimTextureTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimTextureTrack", ref FAnimTextureTrack._ScriptStructPtr);
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x06007232 RID: 29234 RVA: 0x000A37D0 File Offset: 0x000A19D0
		// (set) Token: 0x06007233 RID: 29235 RVA: 0x000A37E0 File Offset: 0x000A19E0
		public unsafe float AnimSeqDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimTextureTrack.__PropertyOffset_AnimSeqDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimTextureTrack.__PropertyOffset_AnimSeqDuration) = value;
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x06007234 RID: 29236 RVA: 0x000A37F1 File Offset: 0x000A19F1
		// (set) Token: 0x06007235 RID: 29237 RVA: 0x000A3801 File Offset: 0x000A1A01
		public unsafe float AnimSeqFramerate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimTextureTrack.__PropertyOffset_AnimSeqFramerate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimTextureTrack.__PropertyOffset_AnimSeqFramerate) = value;
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x06007236 RID: 29238 RVA: 0x000A3812 File Offset: 0x000A1A12
		// (set) Token: 0x06007237 RID: 29239 RVA: 0x000A3822 File Offset: 0x000A1A22
		public unsafe int NumAnimSeqFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimTextureTrack.__PropertyOffset_NumAnimSeqFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimTextureTrack.__PropertyOffset_NumAnimSeqFrames) = value;
			}
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x06007238 RID: 29240 RVA: 0x000A3833 File Offset: 0x000A1A33
		// (set) Token: 0x06007239 RID: 29241 RVA: 0x000A3847 File Offset: 0x000A1A47
		[Nullable(2)]
		public unsafe UAnimationTexture2D AnimTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimTextureTrack.__PropertyOffset_AnimTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimTextureTrack.__PropertyOffset_AnimTexture, value);
			}
		}

		// Token: 0x0600723A RID: 29242 RVA: 0x000A385C File Offset: 0x000A1A5C
		public FAnimTextureTrack()
		{
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x000A3864 File Offset: 0x000A1A64
		[NullableContext(1)]
		public FAnimTextureTrack(FName TrackName, FLinearColor TrackColor, float AnimSeqDuration, float AnimSeqFramerate, int NumAnimSeqFrames, UAnimationTexture2D AnimTexture)
		{
			this.AnimSeqDuration = AnimSeqDuration;
			this.AnimSeqFramerate = AnimSeqFramerate;
			this.NumAnimSeqFrames = NumAnimSeqFrames;
			this.AnimTexture = AnimTexture;
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x000A388B File Offset: 0x000A1A8B
		protected override IntPtr GetUStructPtr()
		{
			return FAnimTextureTrack.StaticStruct();
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x000A3897 File Offset: 0x000A1A97
		[NullableContext(2)]
		public FAnimTextureTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x000A38A1 File Offset: 0x000A1AA1
		public FAnimTextureTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x000A38AC File Offset: 0x000A1AAC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimTextureTrack(Pointer, false, true);
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x000A38B6 File Offset: 0x000A1AB6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimTextureTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040036D4 RID: 14036
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimTextureTrack";

		// Token: 0x040036D5 RID: 14037
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036D6 RID: 14038
		internal static int __PropertyOffset_AnimSeqDuration;

		// Token: 0x040036D7 RID: 14039
		internal static int __PropertyOffset_AnimSeqFramerate;

		// Token: 0x040036D8 RID: 14040
		internal static int __PropertyOffset_NumAnimSeqFrames;

		// Token: 0x040036D9 RID: 14041
		internal static int __PropertyOffset_AnimTexture;
	}
}
