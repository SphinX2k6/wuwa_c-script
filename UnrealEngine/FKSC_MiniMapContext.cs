using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200057D RID: 1405
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_MiniMapContext")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKSC_MiniMapContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007FC6 RID: 32710 RVA: 0x000BCF6D File Offset: 0x000BB16D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_MiniMapContext._ScriptStructPtr != 0) ? FKSC_MiniMapContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_MiniMapContext", ref FKSC_MiniMapContext._ScriptStructPtr);
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06007FC7 RID: 32711 RVA: 0x000BCF91 File Offset: 0x000BB191
		// (set) Token: 0x06007FC8 RID: 32712 RVA: 0x000BCFA1 File Offset: 0x000BB1A1
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

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06007FC9 RID: 32713 RVA: 0x000BCFB2 File Offset: 0x000BB1B2
		// (set) Token: 0x06007FCA RID: 32714 RVA: 0x000BCFC6 File Offset: 0x000BB1C6
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

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06007FCB RID: 32715 RVA: 0x000BCFDB File Offset: 0x000BB1DB
		// (set) Token: 0x06007FCC RID: 32716 RVA: 0x000BCFEB File Offset: 0x000BB1EB
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

		// Token: 0x06007FCD RID: 32717 RVA: 0x000BCFFC File Offset: 0x000BB1FC
		public FKSC_MiniMapContext()
		{
		}

		// Token: 0x06007FCE RID: 32718 RVA: 0x000BD004 File Offset: 0x000BB204
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_MiniMapContext.StaticStruct();
		}

		// Token: 0x06007FCF RID: 32719 RVA: 0x000BD010 File Offset: 0x000BB210
		[NullableContext(2)]
		public FKSC_MiniMapContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007FD0 RID: 32720 RVA: 0x000BD01A File Offset: 0x000BB21A
		public FKSC_MiniMapContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x000BD025 File Offset: 0x000BB225
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_MiniMapContext(Pointer, false, true);
		}

		// Token: 0x06007FD2 RID: 32722 RVA: 0x000BD02F File Offset: 0x000BB22F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_MiniMapContext(Pointer, MemoryOwner);
		}

		// Token: 0x040037CD RID: 14285
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_MiniMapContext";

		// Token: 0x040037CE RID: 14286
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040037CF RID: 14287
		internal static int __PropertyOffset_EnemyType;

		// Token: 0x040037D0 RID: 14288
		internal static int __PropertyOffset_Location;

		// Token: 0x040037D1 RID: 14289
		internal static int __PropertyOffset_Distance;
	}
}
