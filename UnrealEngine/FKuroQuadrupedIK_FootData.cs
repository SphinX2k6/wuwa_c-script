using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200166D RID: 5741
	[UnrealObjectPath("/Script/KuroAnim.KuroQuadrupedIK_FootData")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FKuroQuadrupedIK_FootData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014CF2 RID: 85234 RVA: 0x001E990C File Offset: 0x001E7B0C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroQuadrupedIK_FootData._ScriptStructPtr != 0) ? FKuroQuadrupedIK_FootData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroQuadrupedIK_FootData", ref FKuroQuadrupedIK_FootData._ScriptStructPtr);
		}

		// Token: 0x1700525C RID: 21084
		// (get) Token: 0x06014CF3 RID: 85235 RVA: 0x001E9930 File Offset: 0x001E7B30
		// (set) Token: 0x06014CF4 RID: 85236 RVA: 0x001E9944 File Offset: 0x001E7B44
		public unsafe FName Thigh_Bone_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FootData.__PropertyOffset_Thigh_Bone_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FootData.__PropertyOffset_Thigh_Bone_Name) = value;
			}
		}

		// Token: 0x1700525D RID: 21085
		// (get) Token: 0x06014CF5 RID: 85237 RVA: 0x001E9959 File Offset: 0x001E7B59
		// (set) Token: 0x06014CF6 RID: 85238 RVA: 0x001E996D File Offset: 0x001E7B6D
		public unsafe FName Knee_Bone_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FootData.__PropertyOffset_Knee_Bone_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FootData.__PropertyOffset_Knee_Bone_Name) = value;
			}
		}

		// Token: 0x1700525E RID: 21086
		// (get) Token: 0x06014CF7 RID: 85239 RVA: 0x001E9982 File Offset: 0x001E7B82
		// (set) Token: 0x06014CF8 RID: 85240 RVA: 0x001E9996 File Offset: 0x001E7B96
		public unsafe FName Feet_Bone_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FootData.__PropertyOffset_Feet_Bone_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FootData.__PropertyOffset_Feet_Bone_Name) = value;
			}
		}

		// Token: 0x1700525F RID: 21087
		// (get) Token: 0x06014CF9 RID: 85241 RVA: 0x001E99AB File Offset: 0x001E7BAB
		// (set) Token: 0x06014CFA RID: 85242 RVA: 0x001E99BB File Offset: 0x001E7BBB
		public unsafe float FeetHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FootData.__PropertyOffset_FeetHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FootData.__PropertyOffset_FeetHeight) = value;
			}
		}

		// Token: 0x06014CFB RID: 85243 RVA: 0x001E99CC File Offset: 0x001E7BCC
		public FKuroQuadrupedIK_FootData()
		{
		}

		// Token: 0x06014CFC RID: 85244 RVA: 0x001E99D4 File Offset: 0x001E7BD4
		public FKuroQuadrupedIK_FootData(FName Thigh_Bone_Name, FName Knee_Bone_Name, FName Feet_Bone_Name, float FeetHeight)
		{
			this.Thigh_Bone_Name = Thigh_Bone_Name;
			this.Knee_Bone_Name = Knee_Bone_Name;
			this.Feet_Bone_Name = Feet_Bone_Name;
			this.FeetHeight = FeetHeight;
		}

		// Token: 0x06014CFD RID: 85245 RVA: 0x001E99F9 File Offset: 0x001E7BF9
		protected override IntPtr GetUStructPtr()
		{
			return FKuroQuadrupedIK_FootData.StaticStruct();
		}

		// Token: 0x06014CFE RID: 85246 RVA: 0x001E9A05 File Offset: 0x001E7C05
		[NullableContext(2)]
		public FKuroQuadrupedIK_FootData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014CFF RID: 85247 RVA: 0x001E9A0F File Offset: 0x001E7C0F
		public FKuroQuadrupedIK_FootData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014D00 RID: 85248 RVA: 0x001E9A1A File Offset: 0x001E7C1A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroQuadrupedIK_FootData(Pointer, false, true);
		}

		// Token: 0x06014D01 RID: 85249 RVA: 0x001E9A24 File Offset: 0x001E7C24
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroQuadrupedIK_FootData(Pointer, MemoryOwner);
		}

		// Token: 0x0400B57D RID: 46461
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.KuroQuadrupedIK_FootData";

		// Token: 0x0400B57E RID: 46462
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B57F RID: 46463
		internal static int __PropertyOffset_Thigh_Bone_Name;

		// Token: 0x0400B580 RID: 46464
		internal static int __PropertyOffset_Knee_Bone_Name;

		// Token: 0x0400B581 RID: 46465
		internal static int __PropertyOffset_Feet_Bone_Name;

		// Token: 0x0400B582 RID: 46466
		internal static int __PropertyOffset_FeetHeight;
	}
}
