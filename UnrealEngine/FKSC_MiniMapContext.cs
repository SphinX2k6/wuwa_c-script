using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001DFF RID: 7679
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_MiniMapContext")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKSC_MiniMapContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D556 RID: 120150 RVA: 0x002B4EA6 File Offset: 0x002B30A6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_MiniMapContext._ScriptStructPtr != 0) ? FKSC_MiniMapContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_MiniMapContext", ref FKSC_MiniMapContext._ScriptStructPtr);
		}

		// Token: 0x1700766B RID: 30315
		// (get) Token: 0x0601D557 RID: 120151 RVA: 0x002B4ECA File Offset: 0x002B30CA
		// (set) Token: 0x0601D558 RID: 120152 RVA: 0x002B4EDA File Offset: 0x002B30DA
		public unsafe int EnemyType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_MiniMapContext.__PropertyOffset_EnemyType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_MiniMapContext.__PropertyOffset_EnemyType) = value;
			}
		}

		// Token: 0x1700766C RID: 30316
		// (get) Token: 0x0601D559 RID: 120153 RVA: 0x002B4EEB File Offset: 0x002B30EB
		// (set) Token: 0x0601D55A RID: 120154 RVA: 0x002B4EFF File Offset: 0x002B30FF
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_MiniMapContext.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_MiniMapContext.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700766D RID: 30317
		// (get) Token: 0x0601D55B RID: 120155 RVA: 0x002B4F14 File Offset: 0x002B3114
		// (set) Token: 0x0601D55C RID: 120156 RVA: 0x002B4F24 File Offset: 0x002B3124
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_MiniMapContext.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_MiniMapContext.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x0601D55D RID: 120157 RVA: 0x002B4F35 File Offset: 0x002B3135
		public FKSC_MiniMapContext()
		{
		}

		// Token: 0x0601D55E RID: 120158 RVA: 0x002B4F3D File Offset: 0x002B313D
		public FKSC_MiniMapContext(int EnemyType, FVectorDouble Location, float Distance)
		{
			this.EnemyType = EnemyType;
			this.Location = Location;
			this.Distance = Distance;
		}

		// Token: 0x0601D55F RID: 120159 RVA: 0x002B4F5A File Offset: 0x002B315A
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_MiniMapContext.StaticStruct();
		}

		// Token: 0x0601D560 RID: 120160 RVA: 0x002B4F66 File Offset: 0x002B3166
		[NullableContext(2)]
		public FKSC_MiniMapContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D561 RID: 120161 RVA: 0x002B4F70 File Offset: 0x002B3170
		public FKSC_MiniMapContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D562 RID: 120162 RVA: 0x002B4F7B File Offset: 0x002B317B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_MiniMapContext(Pointer, false, true);
		}

		// Token: 0x0601D563 RID: 120163 RVA: 0x002B4F85 File Offset: 0x002B3185
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_MiniMapContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400FE9E RID: 65182
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_MiniMapContext";

		// Token: 0x0400FE9F RID: 65183
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FEA0 RID: 65184
		internal static int __PropertyOffset_EnemyType;

		// Token: 0x0400FEA1 RID: 65185
		internal static int __PropertyOffset_Location;

		// Token: 0x0400FEA2 RID: 65186
		internal static int __PropertyOffset_Distance;
	}
}
