using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004B4 RID: 1204
	[UnrealObjectPath("/Script/ControlRig.ChannelMapInfo")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FChannelMapInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004014 RID: 16404 RVA: 0x0006059B File Offset: 0x0005E79B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChannelMapInfo._ScriptStructPtr != 0) ? FChannelMapInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ChannelMapInfo", ref FChannelMapInfo._ScriptStructPtr);
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06004015 RID: 16405 RVA: 0x000605BF File Offset: 0x0005E7BF
		// (set) Token: 0x06004016 RID: 16406 RVA: 0x000605CF File Offset: 0x0005E7CF
		public unsafe int ControlIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelMapInfo.__PropertyOffset_ControlIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelMapInfo.__PropertyOffset_ControlIndex) = value;
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06004017 RID: 16407 RVA: 0x000605E0 File Offset: 0x0005E7E0
		// (set) Token: 0x06004018 RID: 16408 RVA: 0x000605F0 File Offset: 0x0005E7F0
		public unsafe int TotalChannelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelMapInfo.__PropertyOffset_TotalChannelIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelMapInfo.__PropertyOffset_TotalChannelIndex) = value;
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06004019 RID: 16409 RVA: 0x00060601 File Offset: 0x0005E801
		// (set) Token: 0x0600401A RID: 16410 RVA: 0x00060611 File Offset: 0x0005E811
		public unsafe int ChannelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelMapInfo.__PropertyOffset_ChannelIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelMapInfo.__PropertyOffset_ChannelIndex) = value;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x0600401B RID: 16411 RVA: 0x00060622 File Offset: 0x0005E822
		// (set) Token: 0x0600401C RID: 16412 RVA: 0x00060632 File Offset: 0x0005E832
		public unsafe int ParentControlIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelMapInfo.__PropertyOffset_ParentControlIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelMapInfo.__PropertyOffset_ParentControlIndex) = value;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600401D RID: 16413 RVA: 0x00060643 File Offset: 0x0005E843
		// (set) Token: 0x0600401E RID: 16414 RVA: 0x00060657 File Offset: 0x0005E857
		public unsafe FName ChannelTypeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChannelMapInfo.__PropertyOffset_ChannelTypeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChannelMapInfo.__PropertyOffset_ChannelTypeName) = value;
			}
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x0006066C File Offset: 0x0005E86C
		public FChannelMapInfo()
		{
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x00060674 File Offset: 0x0005E874
		public FChannelMapInfo(int ControlIndex, int TotalChannelIndex, int ChannelIndex, int ParentControlIndex, FName ChannelTypeName)
		{
			this.ControlIndex = ControlIndex;
			this.TotalChannelIndex = TotalChannelIndex;
			this.ChannelIndex = ChannelIndex;
			this.ParentControlIndex = ParentControlIndex;
			this.ChannelTypeName = ChannelTypeName;
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x000606A1 File Offset: 0x0005E8A1
		protected override IntPtr GetUStructPtr()
		{
			return FChannelMapInfo.StaticStruct();
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x000606AD File Offset: 0x0005E8AD
		[NullableContext(2)]
		public FChannelMapInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x000606B7 File Offset: 0x0005E8B7
		public FChannelMapInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x000606C2 File Offset: 0x0005E8C2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChannelMapInfo(Pointer, false, true);
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x000606CC File Offset: 0x0005E8CC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChannelMapInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04001EA5 RID: 7845
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.ChannelMapInfo";

		// Token: 0x04001EA6 RID: 7846
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EA7 RID: 7847
		internal static int __PropertyOffset_ControlIndex;

		// Token: 0x04001EA8 RID: 7848
		internal static int __PropertyOffset_TotalChannelIndex;

		// Token: 0x04001EA9 RID: 7849
		internal static int __PropertyOffset_ChannelIndex;

		// Token: 0x04001EAA RID: 7850
		internal static int __PropertyOffset_ParentControlIndex;

		// Token: 0x04001EAB RID: 7851
		internal static int __PropertyOffset_ChannelTypeName;
	}
}
