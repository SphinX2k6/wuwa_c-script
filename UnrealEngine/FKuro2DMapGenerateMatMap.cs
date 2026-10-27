using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CDC RID: 3292
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Kuro2DMapGenerateMatMap")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 304)]
	public class FKuro2DMapGenerateMatMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AE85 RID: 44677 RVA: 0x000F7828 File Offset: 0x000F5A28
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuro2DMapGenerateMatMap._ScriptStructPtr != 0) ? FKuro2DMapGenerateMatMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Kuro2DMapGenerateMatMap", ref FKuro2DMapGenerateMatMap._ScriptStructPtr);
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x0600AE86 RID: 44678 RVA: 0x000F784C File Offset: 0x000F5A4C
		// (set) Token: 0x0600AE87 RID: 44679 RVA: 0x000F7860 File Offset: 0x000F5A60
		public unsafe string NameTagRegex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuro2DMapGenerateMatMap.__PropertyOffset_NameTagRegex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuro2DMapGenerateMatMap.__PropertyOffset_NameTagRegex)), value);
			}
		}

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x0600AE88 RID: 44680 RVA: 0x000F7878 File Offset: 0x000F5A78
		// (set) Token: 0x0600AE89 RID: 44681 RVA: 0x000F78BB File Offset: 0x000F5ABB
		public FKuro2DMapGenerateMatMapDetail StaticMeshNameTag
		{
			get
			{
				base.FastCheckIsValid();
				FKuro2DMapGenerateMatMapDetail result;
				if ((result = this._StaticMeshNameTag) == null)
				{
					result = (this._StaticMeshNameTag = new FKuro2DMapGenerateMatMapDetail(base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMap.__PropertyOffset_StaticMeshNameTag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuro2DMapGenerateMatMapDetail.StaticStruct(), base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMap.__PropertyOffset_StaticMeshNameTag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x0600AE8A RID: 44682 RVA: 0x000F78DC File Offset: 0x000F5ADC
		// (set) Token: 0x0600AE8B RID: 44683 RVA: 0x000F791F File Offset: 0x000F5B1F
		public FKuro2DMapGenerateMatMapDetail ParentMaterial
		{
			get
			{
				base.FastCheckIsValid();
				FKuro2DMapGenerateMatMapDetail result;
				if ((result = this._ParentMaterial) == null)
				{
					result = (this._ParentMaterial = new FKuro2DMapGenerateMatMapDetail(base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMap.__PropertyOffset_ParentMaterial, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuro2DMapGenerateMatMapDetail.StaticStruct(), base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMap.__PropertyOffset_ParentMaterial, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x0600AE8C RID: 44684 RVA: 0x000F7940 File Offset: 0x000F5B40
		// (set) Token: 0x0600AE8D RID: 44685 RVA: 0x000F7983 File Offset: 0x000F5B83
		public FKuro2DMapGenerateMatMapDetail StaticMeshPath
		{
			get
			{
				base.FastCheckIsValid();
				FKuro2DMapGenerateMatMapDetail result;
				if ((result = this._StaticMeshPath) == null)
				{
					result = (this._StaticMeshPath = new FKuro2DMapGenerateMatMapDetail(base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMap.__PropertyOffset_StaticMeshPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuro2DMapGenerateMatMapDetail.StaticStruct(), base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMap.__PropertyOffset_StaticMeshPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600AE8E RID: 44686 RVA: 0x000F79A4 File Offset: 0x000F5BA4
		public FKuro2DMapGenerateMatMap()
		{
		}

		// Token: 0x0600AE8F RID: 44687 RVA: 0x000F79AC File Offset: 0x000F5BAC
		public FKuro2DMapGenerateMatMap(string NameTagRegex, FKuro2DMapGenerateMatMapDetail StaticMeshNameTag, FKuro2DMapGenerateMatMapDetail ParentMaterial, FKuro2DMapGenerateMatMapDetail StaticMeshPath)
		{
			this.NameTagRegex = NameTagRegex;
			this.StaticMeshNameTag = StaticMeshNameTag;
			this.ParentMaterial = ParentMaterial;
			this.StaticMeshPath = StaticMeshPath;
		}

		// Token: 0x0600AE90 RID: 44688 RVA: 0x000F79D1 File Offset: 0x000F5BD1
		protected override IntPtr GetUStructPtr()
		{
			return FKuro2DMapGenerateMatMap.StaticStruct();
		}

		// Token: 0x0600AE91 RID: 44689 RVA: 0x000F79DD File Offset: 0x000F5BDD
		[NullableContext(2)]
		public FKuro2DMapGenerateMatMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AE92 RID: 44690 RVA: 0x000F79E7 File Offset: 0x000F5BE7
		public FKuro2DMapGenerateMatMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AE93 RID: 44691 RVA: 0x000F79F2 File Offset: 0x000F5BF2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuro2DMapGenerateMatMap(Pointer, false, true);
		}

		// Token: 0x0600AE94 RID: 44692 RVA: 0x000F79FC File Offset: 0x000F5BFC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuro2DMapGenerateMatMap(Pointer, MemoryOwner);
		}

		// Token: 0x04005B6D RID: 23405
		public const string __ObjectPath = "/Script/Engine.Kuro2DMapGenerateMatMap";

		// Token: 0x04005B6E RID: 23406
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005B6F RID: 23407
		internal static int __PropertyOffset_NameTagRegex;

		// Token: 0x04005B70 RID: 23408
		internal static int __PropertyOffset_StaticMeshNameTag;

		// Token: 0x04005B71 RID: 23409
		[Nullable(2)]
		private FKuro2DMapGenerateMatMapDetail _StaticMeshNameTag;

		// Token: 0x04005B72 RID: 23410
		internal static int __PropertyOffset_ParentMaterial;

		// Token: 0x04005B73 RID: 23411
		[Nullable(2)]
		private FKuro2DMapGenerateMatMapDetail _ParentMaterial;

		// Token: 0x04005B74 RID: 23412
		internal static int __PropertyOffset_StaticMeshPath;

		// Token: 0x04005B75 RID: 23413
		[Nullable(2)]
		private FKuro2DMapGenerateMatMapDetail _StaticMeshPath;
	}
}
