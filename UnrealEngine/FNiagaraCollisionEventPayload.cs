using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002541 RID: 9537
	[UnrealObjectPath("/Script/Niagara.NiagaraCollisionEventPayload")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FNiagaraCollisionEventPayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023654 RID: 144980 RVA: 0x003457A3 File Offset: 0x003439A3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraCollisionEventPayload._ScriptStructPtr != 0) ? FNiagaraCollisionEventPayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraCollisionEventPayload", ref FNiagaraCollisionEventPayload._ScriptStructPtr);
		}

		// Token: 0x17008808 RID: 34824
		// (get) Token: 0x06023655 RID: 144981 RVA: 0x003457C7 File Offset: 0x003439C7
		// (set) Token: 0x06023656 RID: 144982 RVA: 0x003457DB File Offset: 0x003439DB
		public unsafe FVector CollisionPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraCollisionEventPayload.__PropertyOffset_CollisionPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraCollisionEventPayload.__PropertyOffset_CollisionPos) = value;
			}
		}

		// Token: 0x17008809 RID: 34825
		// (get) Token: 0x06023657 RID: 144983 RVA: 0x003457F0 File Offset: 0x003439F0
		// (set) Token: 0x06023658 RID: 144984 RVA: 0x00345804 File Offset: 0x00343A04
		public unsafe FVector CollisionNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraCollisionEventPayload.__PropertyOffset_CollisionNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraCollisionEventPayload.__PropertyOffset_CollisionNormal) = value;
			}
		}

		// Token: 0x1700880A RID: 34826
		// (get) Token: 0x06023659 RID: 144985 RVA: 0x00345819 File Offset: 0x00343A19
		// (set) Token: 0x0602365A RID: 144986 RVA: 0x0034582D File Offset: 0x00343A2D
		public unsafe FVector CollisionVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraCollisionEventPayload.__PropertyOffset_CollisionVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraCollisionEventPayload.__PropertyOffset_CollisionVelocity) = value;
			}
		}

		// Token: 0x1700880B RID: 34827
		// (get) Token: 0x0602365B RID: 144987 RVA: 0x00345842 File Offset: 0x00343A42
		// (set) Token: 0x0602365C RID: 144988 RVA: 0x00345852 File Offset: 0x00343A52
		public unsafe int ParticleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraCollisionEventPayload.__PropertyOffset_ParticleIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraCollisionEventPayload.__PropertyOffset_ParticleIndex) = value;
			}
		}

		// Token: 0x1700880C RID: 34828
		// (get) Token: 0x0602365D RID: 144989 RVA: 0x00345863 File Offset: 0x00343A63
		// (set) Token: 0x0602365E RID: 144990 RVA: 0x00345873 File Offset: 0x00343A73
		public unsafe int PhysicalMaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraCollisionEventPayload.__PropertyOffset_PhysicalMaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraCollisionEventPayload.__PropertyOffset_PhysicalMaterialIndex) = value;
			}
		}

		// Token: 0x0602365F RID: 144991 RVA: 0x00345884 File Offset: 0x00343A84
		public FNiagaraCollisionEventPayload()
		{
		}

		// Token: 0x06023660 RID: 144992 RVA: 0x0034588C File Offset: 0x00343A8C
		public FNiagaraCollisionEventPayload(FVector CollisionPos, FVector CollisionNormal, FVector CollisionVelocity, int ParticleIndex, int PhysicalMaterialIndex)
		{
			this.CollisionPos = CollisionPos;
			this.CollisionNormal = CollisionNormal;
			this.CollisionVelocity = CollisionVelocity;
			this.ParticleIndex = ParticleIndex;
			this.PhysicalMaterialIndex = PhysicalMaterialIndex;
		}

		// Token: 0x06023661 RID: 144993 RVA: 0x003458B9 File Offset: 0x00343AB9
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraCollisionEventPayload.StaticStruct();
		}

		// Token: 0x06023662 RID: 144994 RVA: 0x003458C5 File Offset: 0x00343AC5
		[NullableContext(2)]
		public FNiagaraCollisionEventPayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023663 RID: 144995 RVA: 0x003458CF File Offset: 0x00343ACF
		public FNiagaraCollisionEventPayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023664 RID: 144996 RVA: 0x003458DA File Offset: 0x00343ADA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraCollisionEventPayload(Pointer, false, true);
		}

		// Token: 0x06023665 RID: 144997 RVA: 0x003458E4 File Offset: 0x00343AE4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraCollisionEventPayload(Pointer, MemoryOwner);
		}

		// Token: 0x04012FF0 RID: 77808
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraCollisionEventPayload";

		// Token: 0x04012FF1 RID: 77809
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FF2 RID: 77810
		internal static int __PropertyOffset_CollisionPos;

		// Token: 0x04012FF3 RID: 77811
		internal static int __PropertyOffset_CollisionNormal;

		// Token: 0x04012FF4 RID: 77812
		internal static int __PropertyOffset_CollisionVelocity;

		// Token: 0x04012FF5 RID: 77813
		internal static int __PropertyOffset_ParticleIndex;

		// Token: 0x04012FF6 RID: 77814
		internal static int __PropertyOffset_PhysicalMaterialIndex;
	}
}
