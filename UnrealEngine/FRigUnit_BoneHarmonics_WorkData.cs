using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000557 RID: 1367
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_BoneHarmonics_WorkData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_BoneHarmonics_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004857 RID: 18519 RVA: 0x0006B3F8 File Offset: 0x000695F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_BoneHarmonics_WorkData._ScriptStructPtr != 0) ? FRigUnit_BoneHarmonics_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_BoneHarmonics_WorkData", ref FRigUnit_BoneHarmonics_WorkData._ScriptStructPtr);
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x0006B41C File Offset: 0x0006961C
		// (set) Token: 0x06004859 RID: 18521 RVA: 0x0006B45F File Offset: 0x0006965F
		public TArray<FCachedRigElement> CachedItems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedItems) == null)
				{
					result = (this._CachedItems = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics_WorkData.__PropertyOffset_CachedItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedItems.CopyAssign(value);
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x0006B46D File Offset: 0x0006966D
		// (set) Token: 0x0600485B RID: 18523 RVA: 0x0006B481 File Offset: 0x00069681
		public unsafe FVector WaveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics_WorkData.__PropertyOffset_WaveTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics_WorkData.__PropertyOffset_WaveTime) = value;
			}
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x0006B496 File Offset: 0x00069696
		public FRigUnit_BoneHarmonics_WorkData()
		{
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x0006B49E File Offset: 0x0006969E
		public FRigUnit_BoneHarmonics_WorkData(TArray<FCachedRigElement> CachedItems, FVector WaveTime)
		{
			this.CachedItems = CachedItems;
			this.WaveTime = WaveTime;
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x0006B4B4 File Offset: 0x000696B4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_BoneHarmonics_WorkData.StaticStruct();
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x0006B4C0 File Offset: 0x000696C0
		[NullableContext(2)]
		public FRigUnit_BoneHarmonics_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x0006B4CA File Offset: 0x000696CA
		public FRigUnit_BoneHarmonics_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x0006B4D5 File Offset: 0x000696D5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_BoneHarmonics_WorkData(Pointer, false, true);
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x0006B4DF File Offset: 0x000696DF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_BoneHarmonics_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x04002318 RID: 8984
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_BoneHarmonics_WorkData";

		// Token: 0x04002319 RID: 8985
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400231A RID: 8986
		internal static int __PropertyOffset_CachedItems;

		// Token: 0x0400231B RID: 8987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedItems;

		// Token: 0x0400231C RID: 8988
		internal static int __PropertyOffset_WaveTime;
	}
}
