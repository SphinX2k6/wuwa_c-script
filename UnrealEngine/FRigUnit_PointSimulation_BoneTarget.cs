using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006A4 RID: 1700
	[UnrealObjectPath("/Script/ControlRig.RigUnit_PointSimulation_BoneTarget")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_PointSimulation_BoneTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005A7D RID: 23165 RVA: 0x00081FD0 File Offset: 0x000801D0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_PointSimulation_BoneTarget._ScriptStructPtr != 0) ? FRigUnit_PointSimulation_BoneTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_PointSimulation_BoneTarget", ref FRigUnit_PointSimulation_BoneTarget._ScriptStructPtr);
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06005A7E RID: 23166 RVA: 0x00081FF4 File Offset: 0x000801F4
		// (set) Token: 0x06005A7F RID: 23167 RVA: 0x00082008 File Offset: 0x00080208
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_BoneTarget.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_BoneTarget.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06005A80 RID: 23168 RVA: 0x0008201D File Offset: 0x0008021D
		// (set) Token: 0x06005A81 RID: 23169 RVA: 0x0008202D File Offset: 0x0008022D
		public unsafe int TranslationPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_BoneTarget.__PropertyOffset_TranslationPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_BoneTarget.__PropertyOffset_TranslationPoint) = value;
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06005A82 RID: 23170 RVA: 0x0008203E File Offset: 0x0008023E
		// (set) Token: 0x06005A83 RID: 23171 RVA: 0x0008204E File Offset: 0x0008024E
		public unsafe int PrimaryAimPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_BoneTarget.__PropertyOffset_PrimaryAimPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_BoneTarget.__PropertyOffset_PrimaryAimPoint) = value;
			}
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06005A84 RID: 23172 RVA: 0x0008205F File Offset: 0x0008025F
		// (set) Token: 0x06005A85 RID: 23173 RVA: 0x0008206F File Offset: 0x0008026F
		public unsafe int SecondaryAimPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_BoneTarget.__PropertyOffset_SecondaryAimPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_BoneTarget.__PropertyOffset_SecondaryAimPoint) = value;
			}
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x00082080 File Offset: 0x00080280
		public FRigUnit_PointSimulation_BoneTarget()
		{
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x00082088 File Offset: 0x00080288
		public FRigUnit_PointSimulation_BoneTarget(FName Bone, int TranslationPoint, int PrimaryAimPoint, int SecondaryAimPoint)
		{
			this.Bone = Bone;
			this.TranslationPoint = TranslationPoint;
			this.PrimaryAimPoint = PrimaryAimPoint;
			this.SecondaryAimPoint = SecondaryAimPoint;
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x000820AD File Offset: 0x000802AD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_PointSimulation_BoneTarget.StaticStruct();
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x000820B9 File Offset: 0x000802B9
		[NullableContext(2)]
		public FRigUnit_PointSimulation_BoneTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x000820C3 File Offset: 0x000802C3
		public FRigUnit_PointSimulation_BoneTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x000820CE File Offset: 0x000802CE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_PointSimulation_BoneTarget(Pointer, false, true);
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x000820D8 File Offset: 0x000802D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_PointSimulation_BoneTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04002A63 RID: 10851
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_PointSimulation_BoneTarget";

		// Token: 0x04002A64 RID: 10852
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A65 RID: 10853
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002A66 RID: 10854
		internal static int __PropertyOffset_TranslationPoint;

		// Token: 0x04002A67 RID: 10855
		internal static int __PropertyOffset_PrimaryAimPoint;

		// Token: 0x04002A68 RID: 10856
		internal static int __PropertyOffset_SecondaryAimPoint;
	}
}
