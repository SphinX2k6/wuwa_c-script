using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001401 RID: 5121
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GDKPlatformEditor.GDKCustomChunkMapping")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGDKCustomChunkMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012ADA RID: 76506 RVA: 0x001B7FEA File Offset: 0x001B61EA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGDKCustomChunkMapping._ScriptStructPtr != 0) ? FGDKCustomChunkMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GDKPlatformEditor.GDKCustomChunkMapping", ref FGDKCustomChunkMapping._ScriptStructPtr);
		}

		// Token: 0x17004854 RID: 18516
		// (get) Token: 0x06012ADB RID: 76507 RVA: 0x001B800E File Offset: 0x001B620E
		// (set) Token: 0x06012ADC RID: 76508 RVA: 0x001B801E File Offset: 0x001B621E
		public unsafe int ChunkId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGDKCustomChunkMapping.__PropertyOffset_ChunkId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGDKCustomChunkMapping.__PropertyOffset_ChunkId) = value;
			}
		}

		// Token: 0x17004855 RID: 18517
		// (get) Token: 0x06012ADD RID: 76509 RVA: 0x001B802F File Offset: 0x001B622F
		// (set) Token: 0x06012ADE RID: 76510 RVA: 0x001B8043 File Offset: 0x001B6243
		public unsafe string Pattern
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGDKCustomChunkMapping.__PropertyOffset_Pattern)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGDKCustomChunkMapping.__PropertyOffset_Pattern)), value);
			}
		}

		// Token: 0x17004856 RID: 18518
		// (get) Token: 0x06012ADF RID: 76511 RVA: 0x001B8058 File Offset: 0x001B6258
		// (set) Token: 0x06012AE0 RID: 76512 RVA: 0x001B8068 File Offset: 0x001B6268
		public unsafe EGDKCustomChunkMappingType Type
		{
			get
			{
				return (EGDKCustomChunkMappingType)(*(base.NativePtr + (IntPtr)FGDKCustomChunkMapping.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGDKCustomChunkMapping.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x06012AE1 RID: 76513 RVA: 0x001B8079 File Offset: 0x001B6279
		public FGDKCustomChunkMapping()
		{
		}

		// Token: 0x06012AE2 RID: 76514 RVA: 0x001B8081 File Offset: 0x001B6281
		public FGDKCustomChunkMapping(int ChunkId, string Pattern, EGDKCustomChunkMappingType Type)
		{
			this.ChunkId = ChunkId;
			this.Pattern = Pattern;
			this.Type = Type;
		}

		// Token: 0x06012AE3 RID: 76515 RVA: 0x001B809E File Offset: 0x001B629E
		protected override IntPtr GetUStructPtr()
		{
			return FGDKCustomChunkMapping.StaticStruct();
		}

		// Token: 0x06012AE4 RID: 76516 RVA: 0x001B80AA File Offset: 0x001B62AA
		[NullableContext(2)]
		public FGDKCustomChunkMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012AE5 RID: 76517 RVA: 0x001B80B4 File Offset: 0x001B62B4
		public FGDKCustomChunkMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012AE6 RID: 76518 RVA: 0x001B80BF File Offset: 0x001B62BF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGDKCustomChunkMapping(Pointer, false, true);
		}

		// Token: 0x06012AE7 RID: 76519 RVA: 0x001B80C9 File Offset: 0x001B62C9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGDKCustomChunkMapping(Pointer, MemoryOwner);
		}

		// Token: 0x04009FCA RID: 40906
		public const string __ObjectPath = "/Script/GDKPlatformEditor.GDKCustomChunkMapping";

		// Token: 0x04009FCB RID: 40907
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009FCC RID: 40908
		internal static int __PropertyOffset_ChunkId;

		// Token: 0x04009FCD RID: 40909
		internal static int __PropertyOffset_Pattern;

		// Token: 0x04009FCE RID: 40910
		internal static int __PropertyOffset_Type;
	}
}
