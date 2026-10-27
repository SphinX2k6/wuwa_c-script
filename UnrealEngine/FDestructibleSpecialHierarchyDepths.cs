using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000358 RID: 856
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleSpecialHierarchyDepths")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FDestructibleSpecialHierarchyDepths : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002F9E RID: 12190 RVA: 0x00049098 File Offset: 0x00047298
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDestructibleSpecialHierarchyDepths._ScriptStructPtr != 0) ? FDestructibleSpecialHierarchyDepths._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ApexDestruction.DestructibleSpecialHierarchyDepths", ref FDestructibleSpecialHierarchyDepths._ScriptStructPtr);
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x000490BC File Offset: 0x000472BC
		// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x000490CC File Offset: 0x000472CC
		public unsafe int SupportDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleSpecialHierarchyDepths.__PropertyOffset_SupportDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleSpecialHierarchyDepths.__PropertyOffset_SupportDepth) = value;
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x000490DD File Offset: 0x000472DD
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x000490ED File Offset: 0x000472ED
		public unsafe int MinimumFractureDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleSpecialHierarchyDepths.__PropertyOffset_MinimumFractureDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleSpecialHierarchyDepths.__PropertyOffset_MinimumFractureDepth) = value;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x000490FE File Offset: 0x000472FE
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x0004910E File Offset: 0x0004730E
		public unsafe bool bEnableDebris
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleSpecialHierarchyDepths.__PropertyOffset_bEnableDebris) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleSpecialHierarchyDepths.__PropertyOffset_bEnableDebris) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x0004911F File Offset: 0x0004731F
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x0004912F File Offset: 0x0004732F
		public unsafe int DebrisDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleSpecialHierarchyDepths.__PropertyOffset_DebrisDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleSpecialHierarchyDepths.__PropertyOffset_DebrisDepth) = value;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x00049140 File Offset: 0x00047340
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x00049150 File Offset: 0x00047350
		public unsafe int EssentialDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleSpecialHierarchyDepths.__PropertyOffset_EssentialDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleSpecialHierarchyDepths.__PropertyOffset_EssentialDepth) = value;
			}
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x00049161 File Offset: 0x00047361
		public FDestructibleSpecialHierarchyDepths()
		{
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x00049169 File Offset: 0x00047369
		public FDestructibleSpecialHierarchyDepths(int SupportDepth, int MinimumFractureDepth, bool bEnableDebris, int DebrisDepth, int EssentialDepth)
		{
			this.SupportDepth = SupportDepth;
			this.MinimumFractureDepth = MinimumFractureDepth;
			this.bEnableDebris = bEnableDebris;
			this.DebrisDepth = DebrisDepth;
			this.EssentialDepth = EssentialDepth;
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x00049196 File Offset: 0x00047396
		protected override IntPtr GetUStructPtr()
		{
			return FDestructibleSpecialHierarchyDepths.StaticStruct();
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x000491A2 File Offset: 0x000473A2
		[NullableContext(2)]
		public FDestructibleSpecialHierarchyDepths(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x000491AC File Offset: 0x000473AC
		public FDestructibleSpecialHierarchyDepths(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x000491B7 File Offset: 0x000473B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDestructibleSpecialHierarchyDepths(Pointer, false, true);
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x000491C1 File Offset: 0x000473C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDestructibleSpecialHierarchyDepths(Pointer, MemoryOwner);
		}

		// Token: 0x040014A0 RID: 5280
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ApexDestruction.DestructibleSpecialHierarchyDepths";

		// Token: 0x040014A1 RID: 5281
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040014A2 RID: 5282
		internal static int __PropertyOffset_SupportDepth;

		// Token: 0x040014A3 RID: 5283
		internal static int __PropertyOffset_MinimumFractureDepth;

		// Token: 0x040014A4 RID: 5284
		internal static int __PropertyOffset_bEnableDebris;

		// Token: 0x040014A5 RID: 5285
		internal static int __PropertyOffset_DebrisDepth;

		// Token: 0x040014A6 RID: 5286
		internal static int __PropertyOffset_EssentialDepth;
	}
}
