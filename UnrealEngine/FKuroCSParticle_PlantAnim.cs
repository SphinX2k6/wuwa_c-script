using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017C0 RID: 6080
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_PlantAnim")]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroCSParticle_PlantAnim : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601635D RID: 90973 RVA: 0x0020833C File Offset: 0x0020653C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_PlantAnim._ScriptStructPtr != 0) ? FKuroCSParticle_PlantAnim._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_PlantAnim", ref FKuroCSParticle_PlantAnim._ScriptStructPtr);
		}

		// Token: 0x170058F7 RID: 22775
		// (get) Token: 0x0601635E RID: 90974 RVA: 0x00208360 File Offset: 0x00206560
		// (set) Token: 0x0601635F RID: 90975 RVA: 0x00208374 File Offset: 0x00206574
		public unsafe FVector Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_Pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_Pos) = value;
			}
		}

		// Token: 0x170058F8 RID: 22776
		// (get) Token: 0x06016360 RID: 90976 RVA: 0x00208389 File Offset: 0x00206589
		// (set) Token: 0x06016361 RID: 90977 RVA: 0x00208399 File Offset: 0x00206599
		public unsafe int ParentID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_ParentID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_ParentID) = value;
			}
		}

		// Token: 0x170058F9 RID: 22777
		// (get) Token: 0x06016362 RID: 90978 RVA: 0x002083AA File Offset: 0x002065AA
		// (set) Token: 0x06016363 RID: 90979 RVA: 0x002083BE File Offset: 0x002065BE
		public unsafe FVector Pos_Anim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_Pos_Anim);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_Pos_Anim) = value;
			}
		}

		// Token: 0x170058FA RID: 22778
		// (get) Token: 0x06016364 RID: 90980 RVA: 0x002083D3 File Offset: 0x002065D3
		// (set) Token: 0x06016365 RID: 90981 RVA: 0x002083E3 File Offset: 0x002065E3
		public unsafe int PPID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_PPID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_PPID) = value;
			}
		}

		// Token: 0x170058FB RID: 22779
		// (get) Token: 0x06016366 RID: 90982 RVA: 0x002083F4 File Offset: 0x002065F4
		// (set) Token: 0x06016367 RID: 90983 RVA: 0x00208408 File Offset: 0x00206608
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x170058FC RID: 22780
		// (get) Token: 0x06016368 RID: 90984 RVA: 0x0020841D File Offset: 0x0020661D
		// (set) Token: 0x06016369 RID: 90985 RVA: 0x00208431 File Offset: 0x00206631
		public unsafe FVector Pos_BeforeStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_Pos_BeforeStage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_Pos_BeforeStage) = value;
			}
		}

		// Token: 0x170058FD RID: 22781
		// (get) Token: 0x0601636A RID: 90986 RVA: 0x00208446 File Offset: 0x00206646
		// (set) Token: 0x0601636B RID: 90987 RVA: 0x0020845A File Offset: 0x0020665A
		public unsafe FVector Dir_Bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_Dir_Bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_PlantAnim.__PropertyOffset_Dir_Bind) = value;
			}
		}

		// Token: 0x0601636C RID: 90988 RVA: 0x0020846F File Offset: 0x0020666F
		public FKuroCSParticle_PlantAnim()
		{
		}

		// Token: 0x0601636D RID: 90989 RVA: 0x00208477 File Offset: 0x00206677
		public FKuroCSParticle_PlantAnim(FVector Pos, int ParentID, FVector Pos_Anim, int PPID, FVector Normal, FVector Pos_BeforeStage, FVector Dir_Bind)
		{
			this.Pos = Pos;
			this.ParentID = ParentID;
			this.Pos_Anim = Pos_Anim;
			this.PPID = PPID;
			this.Normal = Normal;
			this.Pos_BeforeStage = Pos_BeforeStage;
			this.Dir_Bind = Dir_Bind;
		}

		// Token: 0x0601636E RID: 90990 RVA: 0x002084B4 File Offset: 0x002066B4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_PlantAnim.StaticStruct();
		}

		// Token: 0x0601636F RID: 90991 RVA: 0x002084C0 File Offset: 0x002066C0
		[NullableContext(2)]
		public FKuroCSParticle_PlantAnim(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016370 RID: 90992 RVA: 0x002084CA File Offset: 0x002066CA
		public FKuroCSParticle_PlantAnim(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016371 RID: 90993 RVA: 0x002084D5 File Offset: 0x002066D5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_PlantAnim(Pointer, false, true);
		}

		// Token: 0x06016372 RID: 90994 RVA: 0x002084DF File Offset: 0x002066DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_PlantAnim(Pointer, MemoryOwner);
		}

		// Token: 0x0400C15C RID: 49500
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_PlantAnim";

		// Token: 0x0400C15D RID: 49501
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C15E RID: 49502
		internal static int __PropertyOffset_Pos;

		// Token: 0x0400C15F RID: 49503
		internal static int __PropertyOffset_ParentID;

		// Token: 0x0400C160 RID: 49504
		internal static int __PropertyOffset_Pos_Anim;

		// Token: 0x0400C161 RID: 49505
		internal static int __PropertyOffset_PPID;

		// Token: 0x0400C162 RID: 49506
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400C163 RID: 49507
		internal static int __PropertyOffset_Pos_BeforeStage;

		// Token: 0x0400C164 RID: 49508
		internal static int __PropertyOffset_Dir_Bind;
	}
}
