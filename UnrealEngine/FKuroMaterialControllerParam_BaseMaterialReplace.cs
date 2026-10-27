using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B3C RID: 6972
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_BaseMaterialReplace")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroMaterialControllerParam_BaseMaterialReplace : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A659 RID: 108121 RVA: 0x0026EA74 File Offset: 0x0026CC74
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_BaseMaterialReplace._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_BaseMaterialReplace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_BaseMaterialReplace", ref FKuroMaterialControllerParam_BaseMaterialReplace._ScriptStructPtr);
		}

		// Token: 0x17006A20 RID: 27168
		// (get) Token: 0x0601A65A RID: 108122 RVA: 0x0026EA98 File Offset: 0x0026CC98
		// (set) Token: 0x0601A65B RID: 108123 RVA: 0x0026EAA8 File Offset: 0x0026CCA8
		public unsafe bool bMatchMaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_BaseMaterialReplace.__PropertyOffset_bMatchMaterialIndex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_BaseMaterialReplace.__PropertyOffset_bMatchMaterialIndex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A21 RID: 27169
		// (get) Token: 0x0601A65C RID: 108124 RVA: 0x0026EABC File Offset: 0x0026CCBC
		// (set) Token: 0x0601A65D RID: 108125 RVA: 0x0026EAFF File Offset: 0x0026CCFF
		public TArray<UMaterialInterface> ReplaceBaseMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ReplaceBaseMaterials) == null)
				{
					result = (this._ReplaceBaseMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_BaseMaterialReplace.__PropertyOffset_ReplaceBaseMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReplaceBaseMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17006A22 RID: 27170
		// (get) Token: 0x0601A65E RID: 108126 RVA: 0x0026EB10 File Offset: 0x0026CD10
		// (set) Token: 0x0601A65F RID: 108127 RVA: 0x0026EB53 File Offset: 0x0026CD53
		public TArray<UMaterialInterface> ReplaceBaseMaterialsMobile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ReplaceBaseMaterialsMobile) == null)
				{
					result = (this._ReplaceBaseMaterialsMobile = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_BaseMaterialReplace.__PropertyOffset_ReplaceBaseMaterialsMobile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReplaceBaseMaterialsMobile.CopyAssign(value);
			}
		}

		// Token: 0x0601A660 RID: 108128 RVA: 0x0026EB61 File Offset: 0x0026CD61
		public FKuroMaterialControllerParam_BaseMaterialReplace()
		{
		}

		// Token: 0x0601A661 RID: 108129 RVA: 0x0026EB69 File Offset: 0x0026CD69
		public FKuroMaterialControllerParam_BaseMaterialReplace(bool bMatchMaterialIndex, TArray<UMaterialInterface> ReplaceBaseMaterials, TArray<UMaterialInterface> ReplaceBaseMaterialsMobile)
		{
			this.bMatchMaterialIndex = bMatchMaterialIndex;
			this.ReplaceBaseMaterials = ReplaceBaseMaterials;
			this.ReplaceBaseMaterialsMobile = ReplaceBaseMaterialsMobile;
		}

		// Token: 0x0601A662 RID: 108130 RVA: 0x0026EB86 File Offset: 0x0026CD86
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_BaseMaterialReplace.StaticStruct();
		}

		// Token: 0x0601A663 RID: 108131 RVA: 0x0026EB92 File Offset: 0x0026CD92
		[NullableContext(2)]
		public FKuroMaterialControllerParam_BaseMaterialReplace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A664 RID: 108132 RVA: 0x0026EB9C File Offset: 0x0026CD9C
		public FKuroMaterialControllerParam_BaseMaterialReplace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A665 RID: 108133 RVA: 0x0026EBA7 File Offset: 0x0026CDA7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_BaseMaterialReplace(Pointer, false, true);
		}

		// Token: 0x0601A666 RID: 108134 RVA: 0x0026EBB1 File Offset: 0x0026CDB1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_BaseMaterialReplace(Pointer, MemoryOwner);
		}

		// Token: 0x0400E4DD RID: 58589
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_BaseMaterialReplace";

		// Token: 0x0400E4DE RID: 58590
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E4DF RID: 58591
		internal static int __PropertyOffset_bMatchMaterialIndex;

		// Token: 0x0400E4E0 RID: 58592
		internal static int __PropertyOffset_ReplaceBaseMaterials;

		// Token: 0x0400E4E1 RID: 58593
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ReplaceBaseMaterials;

		// Token: 0x0400E4E2 RID: 58594
		internal static int __PropertyOffset_ReplaceBaseMaterialsMobile;

		// Token: 0x0400E4E3 RID: 58595
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ReplaceBaseMaterialsMobile;
	}
}
