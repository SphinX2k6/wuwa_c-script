using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C25 RID: 3109
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODActorDesInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FHLODActorDesInfo : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009DD5 RID: 40405 RVA: 0x000E0610 File Offset: 0x000DE810
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODActorDesInfo._ScriptStructPtr != 0) ? FHLODActorDesInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODActorDesInfo", ref FHLODActorDesInfo._ScriptStructPtr);
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x06009DD6 RID: 40406 RVA: 0x000E0634 File Offset: 0x000DE834
		// (set) Token: 0x06009DD7 RID: 40407 RVA: 0x000E0648 File Offset: 0x000DE848
		public unsafe string HLODActorLabel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHLODActorDesInfo.__PropertyOffset_HLODActorLabel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHLODActorDesInfo.__PropertyOffset_HLODActorLabel)), value);
			}
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x000E065D File Offset: 0x000DE85D
		public FHLODActorDesInfo()
		{
		}

		// Token: 0x06009DD9 RID: 40409 RVA: 0x000E0665 File Offset: 0x000DE865
		public FHLODActorDesInfo(string HLODActorLabel)
		{
			this.HLODActorLabel = HLODActorLabel;
		}

		// Token: 0x06009DDA RID: 40410 RVA: 0x000E0674 File Offset: 0x000DE874
		protected override IntPtr GetUStructPtr()
		{
			return FHLODActorDesInfo.StaticStruct();
		}

		// Token: 0x06009DDB RID: 40411 RVA: 0x000E0680 File Offset: 0x000DE880
		[NullableContext(2)]
		public FHLODActorDesInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009DDC RID: 40412 RVA: 0x000E068A File Offset: 0x000DE88A
		public FHLODActorDesInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009DDD RID: 40413 RVA: 0x000E0695 File Offset: 0x000DE895
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODActorDesInfo(Pointer, false, true);
		}

		// Token: 0x06009DDE RID: 40414 RVA: 0x000E069F File Offset: 0x000DE89F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODActorDesInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400570B RID: 22283
		public new const string __ObjectPath = "/Script/Engine.HLODActorDesInfo";

		// Token: 0x0400570C RID: 22284
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400570D RID: 22285
		internal static int __PropertyOffset_HLODActorLabel;
	}
}
