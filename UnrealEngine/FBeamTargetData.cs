using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008AB RID: 2219
	[UnrealObjectPath("/Script/Engine.BeamTargetData")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBeamTargetData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007951 RID: 31057 RVA: 0x000AD9F7 File Offset: 0x000ABBF7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBeamTargetData._ScriptStructPtr != 0) ? FBeamTargetData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BeamTargetData", ref FBeamTargetData._ScriptStructPtr);
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06007952 RID: 31058 RVA: 0x000ADA1B File Offset: 0x000ABC1B
		// (set) Token: 0x06007953 RID: 31059 RVA: 0x000ADA2F File Offset: 0x000ABC2F
		public unsafe FName TargetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBeamTargetData.__PropertyOffset_TargetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBeamTargetData.__PropertyOffset_TargetName) = value;
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06007954 RID: 31060 RVA: 0x000ADA44 File Offset: 0x000ABC44
		// (set) Token: 0x06007955 RID: 31061 RVA: 0x000ADA54 File Offset: 0x000ABC54
		public unsafe float TargetPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBeamTargetData.__PropertyOffset_TargetPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBeamTargetData.__PropertyOffset_TargetPercentage) = value;
			}
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x000ADA65 File Offset: 0x000ABC65
		public FBeamTargetData()
		{
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x000ADA6D File Offset: 0x000ABC6D
		public FBeamTargetData(FName TargetName, float TargetPercentage)
		{
			this.TargetName = TargetName;
			this.TargetPercentage = TargetPercentage;
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x000ADA83 File Offset: 0x000ABC83
		protected override IntPtr GetUStructPtr()
		{
			return FBeamTargetData.StaticStruct();
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x000ADA8F File Offset: 0x000ABC8F
		[NullableContext(2)]
		public FBeamTargetData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x000ADA99 File Offset: 0x000ABC99
		public FBeamTargetData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x000ADAA4 File Offset: 0x000ABCA4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBeamTargetData(Pointer, false, true);
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x000ADAAE File Offset: 0x000ABCAE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBeamTargetData(Pointer, MemoryOwner);
		}

		// Token: 0x04003A50 RID: 14928
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BeamTargetData";

		// Token: 0x04003A51 RID: 14929
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A52 RID: 14930
		internal static int __PropertyOffset_TargetName;

		// Token: 0x04003A53 RID: 14931
		internal static int __PropertyOffset_TargetPercentage;
	}
}
