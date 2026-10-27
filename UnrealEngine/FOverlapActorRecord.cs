using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019E8 RID: 6632
	[UnrealObjectPath("/Script/KuroMovement.OverlapActorRecord")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FOverlapActorRecord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060189AB RID: 100779 RVA: 0x00244133 File Offset: 0x00242333
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOverlapActorRecord._ScriptStructPtr != 0) ? FOverlapActorRecord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMovement.OverlapActorRecord", ref FOverlapActorRecord._ScriptStructPtr);
		}

		// Token: 0x170061F5 RID: 25077
		// (get) Token: 0x060189AC RID: 100780 RVA: 0x00244157 File Offset: 0x00242357
		// (set) Token: 0x060189AD RID: 100781 RVA: 0x00244167 File Offset: 0x00242367
		public unsafe ETriggerAreaType Area
		{
			get
			{
				return (ETriggerAreaType)(*(base.NativePtr + (IntPtr)FOverlapActorRecord.__PropertyOffset_Area));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOverlapActorRecord.__PropertyOffset_Area) = (byte)value;
			}
		}

		// Token: 0x170061F6 RID: 25078
		// (get) Token: 0x060189AE RID: 100782 RVA: 0x00244178 File Offset: 0x00242378
		// (set) Token: 0x060189AF RID: 100783 RVA: 0x0024418C File Offset: 0x0024238C
		[Nullable(2)]
		public unsafe AActor Actor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FOverlapActorRecord.__PropertyOffset_Actor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FOverlapActorRecord.__PropertyOffset_Actor, value);
			}
		}

		// Token: 0x170061F7 RID: 25079
		// (get) Token: 0x060189B0 RID: 100784 RVA: 0x002441A1 File Offset: 0x002423A1
		// (set) Token: 0x060189B1 RID: 100785 RVA: 0x002441B1 File Offset: 0x002423B1
		public unsafe bool EnterOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOverlapActorRecord.__PropertyOffset_EnterOverlap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOverlapActorRecord.__PropertyOffset_EnterOverlap) = (value ? 1 : 0);
			}
		}

		// Token: 0x060189B2 RID: 100786 RVA: 0x002441C2 File Offset: 0x002423C2
		public FOverlapActorRecord()
		{
		}

		// Token: 0x060189B3 RID: 100787 RVA: 0x002441CA File Offset: 0x002423CA
		[NullableContext(1)]
		public FOverlapActorRecord(ETriggerAreaType Area, AActor Actor, bool EnterOverlap)
		{
			this.Area = Area;
			this.Actor = Actor;
			this.EnterOverlap = EnterOverlap;
		}

		// Token: 0x060189B4 RID: 100788 RVA: 0x002441E7 File Offset: 0x002423E7
		protected override IntPtr GetUStructPtr()
		{
			return FOverlapActorRecord.StaticStruct();
		}

		// Token: 0x060189B5 RID: 100789 RVA: 0x002441F3 File Offset: 0x002423F3
		[NullableContext(2)]
		public FOverlapActorRecord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060189B6 RID: 100790 RVA: 0x002441FD File Offset: 0x002423FD
		public FOverlapActorRecord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060189B7 RID: 100791 RVA: 0x00244208 File Offset: 0x00242408
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOverlapActorRecord(Pointer, false, true);
		}

		// Token: 0x060189B8 RID: 100792 RVA: 0x00244212 File Offset: 0x00242412
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOverlapActorRecord(Pointer, MemoryOwner);
		}

		// Token: 0x0400D4CA RID: 54474
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMovement.OverlapActorRecord";

		// Token: 0x0400D4CB RID: 54475
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D4CC RID: 54476
		internal static int __PropertyOffset_Area;

		// Token: 0x0400D4CD RID: 54477
		internal static int __PropertyOffset_Actor;

		// Token: 0x0400D4CE RID: 54478
		internal static int __PropertyOffset_EnterOverlap;
	}
}
