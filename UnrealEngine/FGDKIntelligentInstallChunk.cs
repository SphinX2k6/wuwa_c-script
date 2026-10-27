using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001402 RID: 5122
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GDKPlatformEditor.GDKIntelligentInstallChunk")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGDKIntelligentInstallChunk : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012AE8 RID: 76520 RVA: 0x001B80D2 File Offset: 0x001B62D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGDKIntelligentInstallChunk._ScriptStructPtr != 0) ? FGDKIntelligentInstallChunk._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GDKPlatformEditor.GDKIntelligentInstallChunk", ref FGDKIntelligentInstallChunk._ScriptStructPtr);
		}

		// Token: 0x17004857 RID: 18519
		// (get) Token: 0x06012AE9 RID: 76521 RVA: 0x001B80F6 File Offset: 0x001B62F6
		// (set) Token: 0x06012AEA RID: 76522 RVA: 0x001B8106 File Offset: 0x001B6306
		public unsafe int ChunkId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGDKIntelligentInstallChunk.__PropertyOffset_ChunkId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGDKIntelligentInstallChunk.__PropertyOffset_ChunkId) = value;
			}
		}

		// Token: 0x17004858 RID: 18520
		// (get) Token: 0x06012AEB RID: 76523 RVA: 0x001B8117 File Offset: 0x001B6317
		// (set) Token: 0x06012AEC RID: 76524 RVA: 0x001B8127 File Offset: 0x001B6327
		public unsafe EGDKIntelligentInstallChunkType ChunkType
		{
			get
			{
				return (EGDKIntelligentInstallChunkType)(*(base.NativePtr + (IntPtr)FGDKIntelligentInstallChunk.__PropertyOffset_ChunkType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGDKIntelligentInstallChunk.__PropertyOffset_ChunkType) = (byte)value;
			}
		}

		// Token: 0x17004859 RID: 18521
		// (get) Token: 0x06012AED RID: 76525 RVA: 0x001B8138 File Offset: 0x001B6338
		// (set) Token: 0x06012AEE RID: 76526 RVA: 0x001B814C File Offset: 0x001B634C
		public unsafe string Tag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGDKIntelligentInstallChunk.__PropertyOffset_Tag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGDKIntelligentInstallChunk.__PropertyOffset_Tag)), value);
			}
		}

		// Token: 0x06012AEF RID: 76527 RVA: 0x001B8161 File Offset: 0x001B6361
		public FGDKIntelligentInstallChunk()
		{
		}

		// Token: 0x06012AF0 RID: 76528 RVA: 0x001B8169 File Offset: 0x001B6369
		public FGDKIntelligentInstallChunk(int ChunkId, EGDKIntelligentInstallChunkType ChunkType, string Tag)
		{
			this.ChunkId = ChunkId;
			this.ChunkType = ChunkType;
			this.Tag = Tag;
		}

		// Token: 0x06012AF1 RID: 76529 RVA: 0x001B8186 File Offset: 0x001B6386
		protected override IntPtr GetUStructPtr()
		{
			return FGDKIntelligentInstallChunk.StaticStruct();
		}

		// Token: 0x06012AF2 RID: 76530 RVA: 0x001B8192 File Offset: 0x001B6392
		[NullableContext(2)]
		public FGDKIntelligentInstallChunk(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012AF3 RID: 76531 RVA: 0x001B819C File Offset: 0x001B639C
		public FGDKIntelligentInstallChunk(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012AF4 RID: 76532 RVA: 0x001B81A7 File Offset: 0x001B63A7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGDKIntelligentInstallChunk(Pointer, false, true);
		}

		// Token: 0x06012AF5 RID: 76533 RVA: 0x001B81B1 File Offset: 0x001B63B1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGDKIntelligentInstallChunk(Pointer, MemoryOwner);
		}

		// Token: 0x04009FCF RID: 40911
		public const string __ObjectPath = "/Script/GDKPlatformEditor.GDKIntelligentInstallChunk";

		// Token: 0x04009FD0 RID: 40912
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009FD1 RID: 40913
		internal static int __PropertyOffset_ChunkId;

		// Token: 0x04009FD2 RID: 40914
		internal static int __PropertyOffset_ChunkType;

		// Token: 0x04009FD3 RID: 40915
		internal static int __PropertyOffset_Tag;
	}
}
