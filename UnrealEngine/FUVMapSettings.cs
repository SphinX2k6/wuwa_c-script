using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028C4 RID: 10436
	[UnrealObjectPath("/Script/StaticMeshDescription.UVMapSettings")]
	[UnrealStructLayout(56, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FUVMapSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026BF2 RID: 158706 RVA: 0x003B1C4E File Offset: 0x003AFE4E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUVMapSettings._ScriptStructPtr != 0) ? FUVMapSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/StaticMeshDescription.UVMapSettings", ref FUVMapSettings._ScriptStructPtr);
		}

		// Token: 0x17009546 RID: 38214
		// (get) Token: 0x06026BF3 RID: 158707 RVA: 0x003B1C72 File Offset: 0x003AFE72
		// (set) Token: 0x06026BF4 RID: 158708 RVA: 0x003B1C86 File Offset: 0x003AFE86
		public unsafe FVector Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUVMapSettings.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUVMapSettings.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17009547 RID: 38215
		// (get) Token: 0x06026BF5 RID: 158709 RVA: 0x003B1C9B File Offset: 0x003AFE9B
		// (set) Token: 0x06026BF6 RID: 158710 RVA: 0x003B1CAF File Offset: 0x003AFEAF
		public unsafe FVector2D UVTile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUVMapSettings.__PropertyOffset_UVTile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUVMapSettings.__PropertyOffset_UVTile) = value;
			}
		}

		// Token: 0x17009548 RID: 38216
		// (get) Token: 0x06026BF7 RID: 158711 RVA: 0x003B1CC4 File Offset: 0x003AFEC4
		// (set) Token: 0x06026BF8 RID: 158712 RVA: 0x003B1CD8 File Offset: 0x003AFED8
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUVMapSettings.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUVMapSettings.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17009549 RID: 38217
		// (get) Token: 0x06026BF9 RID: 158713 RVA: 0x003B1CED File Offset: 0x003AFEED
		// (set) Token: 0x06026BFA RID: 158714 RVA: 0x003B1D01 File Offset: 0x003AFF01
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUVMapSettings.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUVMapSettings.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x1700954A RID: 38218
		// (get) Token: 0x06026BFB RID: 158715 RVA: 0x003B1D16 File Offset: 0x003AFF16
		// (set) Token: 0x06026BFC RID: 158716 RVA: 0x003B1D2A File Offset: 0x003AFF2A
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUVMapSettings.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUVMapSettings.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x06026BFD RID: 158717 RVA: 0x003B1D3F File Offset: 0x003AFF3F
		public FUVMapSettings()
		{
		}

		// Token: 0x06026BFE RID: 158718 RVA: 0x003B1D47 File Offset: 0x003AFF47
		public FUVMapSettings(FVector Size, FVector2D UVTile, FVector Position, FRotator Rotation, FVector Scale)
		{
			this.Size = Size;
			this.UVTile = UVTile;
			this.Position = Position;
			this.Rotation = Rotation;
			this.Scale = Scale;
		}

		// Token: 0x06026BFF RID: 158719 RVA: 0x003B1D74 File Offset: 0x003AFF74
		protected override IntPtr GetUStructPtr()
		{
			return FUVMapSettings.StaticStruct();
		}

		// Token: 0x06026C00 RID: 158720 RVA: 0x003B1D80 File Offset: 0x003AFF80
		[NullableContext(2)]
		public FUVMapSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026C01 RID: 158721 RVA: 0x003B1D8A File Offset: 0x003AFF8A
		public FUVMapSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026C02 RID: 158722 RVA: 0x003B1D95 File Offset: 0x003AFF95
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUVMapSettings(Pointer, false, true);
		}

		// Token: 0x06026C03 RID: 158723 RVA: 0x003B1D9F File Offset: 0x003AFF9F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUVMapSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04015432 RID: 87090
		[Nullable(1)]
		public const string __ObjectPath = "/Script/StaticMeshDescription.UVMapSettings";

		// Token: 0x04015433 RID: 87091
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015434 RID: 87092
		internal static int __PropertyOffset_Size;

		// Token: 0x04015435 RID: 87093
		internal static int __PropertyOffset_UVTile;

		// Token: 0x04015436 RID: 87094
		internal static int __PropertyOffset_Position;

		// Token: 0x04015437 RID: 87095
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04015438 RID: 87096
		internal static int __PropertyOffset_Scale;
	}
}
