using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C0E RID: 3086
	[UnrealObjectPath("/Script/Engine.GPUSpriteLocalVectorFieldInfo")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FGPUSpriteLocalVectorFieldInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009BA6 RID: 39846 RVA: 0x000DD4CC File Offset: 0x000DB6CC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGPUSpriteLocalVectorFieldInfo._ScriptStructPtr != 0) ? FGPUSpriteLocalVectorFieldInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.GPUSpriteLocalVectorFieldInfo", ref FGPUSpriteLocalVectorFieldInfo._ScriptStructPtr);
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x06009BA7 RID: 39847 RVA: 0x000DD4F0 File Offset: 0x000DB6F0
		// (set) Token: 0x06009BA8 RID: 39848 RVA: 0x000DD504 File Offset: 0x000DB704
		[Nullable(2)]
		public unsafe UVectorField Field
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVectorField>(base.NativePtr / (IntPtr)sizeof(void*) + FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_Field);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_Field, value);
			}
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x06009BA9 RID: 39849 RVA: 0x000DD519 File Offset: 0x000DB719
		// (set) Token: 0x06009BAA RID: 39850 RVA: 0x000DD52D File Offset: 0x000DB72D
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x06009BAB RID: 39851 RVA: 0x000DD542 File Offset: 0x000DB742
		// (set) Token: 0x06009BAC RID: 39852 RVA: 0x000DD556 File Offset: 0x000DB756
		public unsafe FRotator MinInitialRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_MinInitialRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_MinInitialRotation) = value;
			}
		}

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x06009BAD RID: 39853 RVA: 0x000DD56B File Offset: 0x000DB76B
		// (set) Token: 0x06009BAE RID: 39854 RVA: 0x000DD57F File Offset: 0x000DB77F
		public unsafe FRotator MaxInitialRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_MaxInitialRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_MaxInitialRotation) = value;
			}
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x06009BAF RID: 39855 RVA: 0x000DD594 File Offset: 0x000DB794
		// (set) Token: 0x06009BB0 RID: 39856 RVA: 0x000DD5A8 File Offset: 0x000DB7A8
		public unsafe FRotator RotationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_RotationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_RotationRate) = value;
			}
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x06009BB1 RID: 39857 RVA: 0x000DD5BD File Offset: 0x000DB7BD
		// (set) Token: 0x06009BB2 RID: 39858 RVA: 0x000DD5CD File Offset: 0x000DB7CD
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x06009BB3 RID: 39859 RVA: 0x000DD5DE File Offset: 0x000DB7DE
		// (set) Token: 0x06009BB4 RID: 39860 RVA: 0x000DD5EE File Offset: 0x000DB7EE
		public unsafe float Tightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_Tightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_Tightness) = value;
			}
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x06009BB5 RID: 39861 RVA: 0x000DD5FF File Offset: 0x000DB7FF
		// (set) Token: 0x06009BB6 RID: 39862 RVA: 0x000DD618 File Offset: 0x000DB818
		public unsafe bool bIgnoreComponentTransform
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bIgnoreComponentTransform) & FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bIgnoreComponentTransform) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bIgnoreComponentTransform) = ((*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bIgnoreComponentTransform) & ~FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bIgnoreComponentTransform) | (value ? FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bIgnoreComponentTransform : 0));
			}
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x06009BB7 RID: 39863 RVA: 0x000DD648 File Offset: 0x000DB848
		// (set) Token: 0x06009BB8 RID: 39864 RVA: 0x000DD661 File Offset: 0x000DB861
		public unsafe bool bTileX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bTileX) & FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bTileX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bTileX) = ((*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bTileX) & ~FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bTileX) | (value ? FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bTileX : 0));
			}
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x06009BB9 RID: 39865 RVA: 0x000DD691 File Offset: 0x000DB891
		// (set) Token: 0x06009BBA RID: 39866 RVA: 0x000DD6AA File Offset: 0x000DB8AA
		public unsafe bool bTileY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bTileY) & FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bTileY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bTileY) = ((*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bTileY) & ~FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bTileY) | (value ? FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bTileY : 0));
			}
		}

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x06009BBB RID: 39867 RVA: 0x000DD6DA File Offset: 0x000DB8DA
		// (set) Token: 0x06009BBC RID: 39868 RVA: 0x000DD6F3 File Offset: 0x000DB8F3
		public unsafe bool bTileZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bTileZ) & FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bTileZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bTileZ) = ((*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bTileZ) & ~FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bTileZ) | (value ? FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bTileZ : 0));
			}
		}

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x06009BBD RID: 39869 RVA: 0x000DD723 File Offset: 0x000DB923
		// (set) Token: 0x06009BBE RID: 39870 RVA: 0x000DD73C File Offset: 0x000DB93C
		public unsafe bool bUseFixDT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bUseFixDT) & FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bUseFixDT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bUseFixDT) = ((*(base.NativePtr + (IntPtr)FGPUSpriteLocalVectorFieldInfo.__PropertyOffset_bUseFixDT) & ~FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bUseFixDT) | (value ? FGPUSpriteLocalVectorFieldInfo.__PropertyMask_bUseFixDT : 0));
			}
		}

		// Token: 0x06009BBF RID: 39871 RVA: 0x000DD76C File Offset: 0x000DB96C
		public FGPUSpriteLocalVectorFieldInfo()
		{
		}

		// Token: 0x06009BC0 RID: 39872 RVA: 0x000DD774 File Offset: 0x000DB974
		[NullableContext(1)]
		public FGPUSpriteLocalVectorFieldInfo(UVectorField Field, FTransform Transform, FRotator MinInitialRotation, FRotator MaxInitialRotation, FRotator RotationRate, float Intensity, float Tightness, bool bIgnoreComponentTransform, bool bTileX, bool bTileY, bool bTileZ, bool bUseFixDT)
		{
			this.Field = Field;
			this.Transform = Transform;
			this.MinInitialRotation = MinInitialRotation;
			this.MaxInitialRotation = MaxInitialRotation;
			this.RotationRate = RotationRate;
			this.Intensity = Intensity;
			this.Tightness = Tightness;
			this.bIgnoreComponentTransform = bIgnoreComponentTransform;
			this.bTileX = bTileX;
			this.bTileY = bTileY;
			this.bTileZ = bTileZ;
			this.bUseFixDT = bUseFixDT;
		}

		// Token: 0x06009BC1 RID: 39873 RVA: 0x000DD7E4 File Offset: 0x000DB9E4
		protected override IntPtr GetUStructPtr()
		{
			return FGPUSpriteLocalVectorFieldInfo.StaticStruct();
		}

		// Token: 0x06009BC2 RID: 39874 RVA: 0x000DD7F0 File Offset: 0x000DB9F0
		[NullableContext(2)]
		public FGPUSpriteLocalVectorFieldInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009BC3 RID: 39875 RVA: 0x000DD7FA File Offset: 0x000DB9FA
		public FGPUSpriteLocalVectorFieldInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009BC4 RID: 39876 RVA: 0x000DD805 File Offset: 0x000DBA05
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGPUSpriteLocalVectorFieldInfo(Pointer, false, true);
		}

		// Token: 0x06009BC5 RID: 39877 RVA: 0x000DD80F File Offset: 0x000DBA0F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGPUSpriteLocalVectorFieldInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040055EF RID: 21999
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.GPUSpriteLocalVectorFieldInfo";

		// Token: 0x040055F0 RID: 22000
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040055F1 RID: 22001
		internal static int __PropertyOffset_Field;

		// Token: 0x040055F2 RID: 22002
		internal static int __PropertyOffset_Transform;

		// Token: 0x040055F3 RID: 22003
		internal static int __PropertyOffset_MinInitialRotation;

		// Token: 0x040055F4 RID: 22004
		internal static int __PropertyOffset_MaxInitialRotation;

		// Token: 0x040055F5 RID: 22005
		internal static int __PropertyOffset_RotationRate;

		// Token: 0x040055F6 RID: 22006
		internal static int __PropertyOffset_Intensity;

		// Token: 0x040055F7 RID: 22007
		internal static int __PropertyOffset_Tightness;

		// Token: 0x040055F8 RID: 22008
		internal static int __PropertyOffset_bIgnoreComponentTransform;

		// Token: 0x040055F9 RID: 22009
		internal static byte __PropertyMask_bIgnoreComponentTransform;

		// Token: 0x040055FA RID: 22010
		internal static int __PropertyOffset_bTileX;

		// Token: 0x040055FB RID: 22011
		internal static byte __PropertyMask_bTileX;

		// Token: 0x040055FC RID: 22012
		internal static int __PropertyOffset_bTileY;

		// Token: 0x040055FD RID: 22013
		internal static byte __PropertyMask_bTileY;

		// Token: 0x040055FE RID: 22014
		internal static int __PropertyOffset_bTileZ;

		// Token: 0x040055FF RID: 22015
		internal static byte __PropertyMask_bTileZ;

		// Token: 0x04005600 RID: 22016
		internal static int __PropertyOffset_bUseFixDT;

		// Token: 0x04005601 RID: 22017
		internal static byte __PropertyMask_bUseFixDT;
	}
}
