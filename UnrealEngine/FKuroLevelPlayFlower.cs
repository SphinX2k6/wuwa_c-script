using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018E9 RID: 6377
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayFlower")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroLevelPlayFlower : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017A50 RID: 96848 RVA: 0x0022A75A File Offset: 0x0022895A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelPlayFlower._ScriptStructPtr != 0) ? FKuroLevelPlayFlower._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroLevelPlayFlower", ref FKuroLevelPlayFlower._ScriptStructPtr);
		}

		// Token: 0x17005F49 RID: 24393
		// (get) Token: 0x06017A51 RID: 96849 RVA: 0x0022A780 File Offset: 0x00228980
		// (set) Token: 0x06017A52 RID: 96850 RVA: 0x0022A7C3 File Offset: 0x002289C3
		public FKuroLevelPlayCircle Circle
		{
			get
			{
				base.FastCheckIsValid();
				FKuroLevelPlayCircle result;
				if ((result = this._Circle) == null)
				{
					result = (this._Circle = new FKuroLevelPlayCircle(base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_Circle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroLevelPlayCircle.StaticStruct(), base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_Circle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F4A RID: 24394
		// (get) Token: 0x06017A53 RID: 96851 RVA: 0x0022A7E4 File Offset: 0x002289E4
		// (set) Token: 0x06017A54 RID: 96852 RVA: 0x0022A7F4 File Offset: 0x002289F4
		public unsafe bool Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_Value) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_Value) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F4B RID: 24395
		// (get) Token: 0x06017A55 RID: 96853 RVA: 0x0022A805 File Offset: 0x00228A05
		// (set) Token: 0x06017A56 RID: 96854 RVA: 0x0022A815 File Offset: 0x00228A15
		public unsafe int GamePartitionID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_GamePartitionID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_GamePartitionID) = value;
			}
		}

		// Token: 0x17005F4C RID: 24396
		// (get) Token: 0x06017A57 RID: 96855 RVA: 0x0022A826 File Offset: 0x00228A26
		// (set) Token: 0x06017A58 RID: 96856 RVA: 0x0022A836 File Offset: 0x00228A36
		public unsafe int SplinePbDataId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_SplinePbDataId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_SplinePbDataId) = value;
			}
		}

		// Token: 0x17005F4D RID: 24397
		// (get) Token: 0x06017A59 RID: 96857 RVA: 0x0022A847 File Offset: 0x00228A47
		// (set) Token: 0x06017A5A RID: 96858 RVA: 0x0022A857 File Offset: 0x00228A57
		public unsafe int DiffusionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_DiffusionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_DiffusionRadius) = value;
			}
		}

		// Token: 0x17005F4E RID: 24398
		// (get) Token: 0x06017A5B RID: 96859 RVA: 0x0022A868 File Offset: 0x00228A68
		// (set) Token: 0x06017A5C RID: 96860 RVA: 0x0022A878 File Offset: 0x00228A78
		public unsafe bool bDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_bDirty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayFlower.__PropertyOffset_bDirty) = (value ? 1 : 0);
			}
		}

		// Token: 0x06017A5D RID: 96861 RVA: 0x0022A889 File Offset: 0x00228A89
		public FKuroLevelPlayFlower()
		{
		}

		// Token: 0x06017A5E RID: 96862 RVA: 0x0022A891 File Offset: 0x00228A91
		public FKuroLevelPlayFlower(FKuroLevelPlayCircle Circle, bool Value, int GamePartitionID, int SplinePbDataId, int DiffusionRadius, bool bDirty)
		{
			this.Circle = Circle;
			this.Value = Value;
			this.GamePartitionID = GamePartitionID;
			this.SplinePbDataId = SplinePbDataId;
			this.DiffusionRadius = DiffusionRadius;
			this.bDirty = bDirty;
		}

		// Token: 0x06017A5F RID: 96863 RVA: 0x0022A8C6 File Offset: 0x00228AC6
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelPlayFlower.StaticStruct();
		}

		// Token: 0x06017A60 RID: 96864 RVA: 0x0022A8D2 File Offset: 0x00228AD2
		[NullableContext(2)]
		public FKuroLevelPlayFlower(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017A61 RID: 96865 RVA: 0x0022A8DC File Offset: 0x00228ADC
		public FKuroLevelPlayFlower(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017A62 RID: 96866 RVA: 0x0022A8E7 File Offset: 0x00228AE7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelPlayFlower(Pointer, false, true);
		}

		// Token: 0x06017A63 RID: 96867 RVA: 0x0022A8F1 File Offset: 0x00228AF1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelPlayFlower(Pointer, MemoryOwner);
		}

		// Token: 0x0400CD81 RID: 52609
		public const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayFlower";

		// Token: 0x0400CD82 RID: 52610
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CD83 RID: 52611
		internal static int __PropertyOffset_Circle;

		// Token: 0x0400CD84 RID: 52612
		[Nullable(2)]
		private FKuroLevelPlayCircle _Circle;

		// Token: 0x0400CD85 RID: 52613
		internal static int __PropertyOffset_Value;

		// Token: 0x0400CD86 RID: 52614
		internal static int __PropertyOffset_GamePartitionID;

		// Token: 0x0400CD87 RID: 52615
		internal static int __PropertyOffset_SplinePbDataId;

		// Token: 0x0400CD88 RID: 52616
		internal static int __PropertyOffset_DiffusionRadius;

		// Token: 0x0400CD89 RID: 52617
		internal static int __PropertyOffset_bDirty;
	}
}
