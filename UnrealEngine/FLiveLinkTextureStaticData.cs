using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002223 RID: 8739
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTextureStaticData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FLiveLinkTextureStaticData : FLiveLinkBaseStaticData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021483 RID: 136323 RVA: 0x00310F78 File Offset: 0x0030F178
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTextureStaticData._ScriptStructPtr != 0) ? FLiveLinkTextureStaticData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTextureStaticData", ref FLiveLinkTextureStaticData._ScriptStructPtr);
		}

		// Token: 0x170081EB RID: 33259
		// (get) Token: 0x06021484 RID: 136324 RVA: 0x00310F9C File Offset: 0x0030F19C
		// (set) Token: 0x06021485 RID: 136325 RVA: 0x00310FAC File Offset: 0x0030F1AC
		public unsafe int LODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureStaticData.__PropertyOffset_LODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureStaticData.__PropertyOffset_LODIndex) = value;
			}
		}

		// Token: 0x170081EC RID: 33260
		// (get) Token: 0x06021486 RID: 136326 RVA: 0x00310FBD File Offset: 0x0030F1BD
		// (set) Token: 0x06021487 RID: 136327 RVA: 0x00310FCD File Offset: 0x0030F1CD
		public unsafe int SectionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureStaticData.__PropertyOffset_SectionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureStaticData.__PropertyOffset_SectionIndex) = value;
			}
		}

		// Token: 0x170081ED RID: 33261
		// (get) Token: 0x06021488 RID: 136328 RVA: 0x00310FDE File Offset: 0x0030F1DE
		// (set) Token: 0x06021489 RID: 136329 RVA: 0x00310FF2 File Offset: 0x0030F1F2
		public unsafe string SectionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLiveLinkTextureStaticData.__PropertyOffset_SectionName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLiveLinkTextureStaticData.__PropertyOffset_SectionName)), value);
			}
		}

		// Token: 0x0602148A RID: 136330 RVA: 0x00311007 File Offset: 0x0030F207
		public FLiveLinkTextureStaticData()
		{
		}

		// Token: 0x0602148B RID: 136331 RVA: 0x0031100F File Offset: 0x0030F20F
		public FLiveLinkTextureStaticData(int LODIndex, int SectionIndex, string SectionName, TArray<FName> PropertyNames)
		{
			this.LODIndex = LODIndex;
			this.SectionIndex = SectionIndex;
			this.SectionName = SectionName;
			base.PropertyNames = PropertyNames;
		}

		// Token: 0x0602148C RID: 136332 RVA: 0x00311034 File Offset: 0x0030F234
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTextureStaticData.StaticStruct();
		}

		// Token: 0x0602148D RID: 136333 RVA: 0x00311040 File Offset: 0x0030F240
		[NullableContext(2)]
		public FLiveLinkTextureStaticData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602148E RID: 136334 RVA: 0x0031104A File Offset: 0x0030F24A
		public FLiveLinkTextureStaticData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602148F RID: 136335 RVA: 0x00311055 File Offset: 0x0030F255
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTextureStaticData(Pointer, false, true);
		}

		// Token: 0x06021490 RID: 136336 RVA: 0x0031105F File Offset: 0x0030F25F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTextureStaticData(Pointer, MemoryOwner);
		}

		// Token: 0x04011C04 RID: 72708
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTextureStaticData";

		// Token: 0x04011C05 RID: 72709
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C06 RID: 72710
		internal static int __PropertyOffset_LODIndex;

		// Token: 0x04011C07 RID: 72711
		internal static int __PropertyOffset_SectionIndex;

		// Token: 0x04011C08 RID: 72712
		internal static int __PropertyOffset_SectionName;
	}
}
