using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200180A RID: 6154
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.BatchKeyInfo")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FBatchKeyInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016C64 RID: 93284 RVA: 0x00213C27 File Offset: 0x00211E27
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBatchKeyInfo._ScriptStructPtr != 0) ? FBatchKeyInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroDynamicMeshBatch.BatchKeyInfo", ref FBatchKeyInfo._ScriptStructPtr);
		}

		// Token: 0x17005C04 RID: 23556
		// (get) Token: 0x06016C65 RID: 93285 RVA: 0x00213C4B File Offset: 0x00211E4B
		// (set) Token: 0x06016C66 RID: 93286 RVA: 0x00213C5F File Offset: 0x00211E5F
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FBatchKeyInfo.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBatchKeyInfo.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17005C05 RID: 23557
		// (get) Token: 0x06016C67 RID: 93287 RVA: 0x00213C74 File Offset: 0x00211E74
		// (set) Token: 0x06016C68 RID: 93288 RVA: 0x00213C88 File Offset: 0x00211E88
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FBatchKeyInfo.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBatchKeyInfo.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17005C06 RID: 23558
		// (get) Token: 0x06016C69 RID: 93289 RVA: 0x00213CA0 File Offset: 0x00211EA0
		// (set) Token: 0x06016C6A RID: 93290 RVA: 0x00213CE3 File Offset: 0x00211EE3
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TWeakObjectPtr<USceneComponent>, int> InstanceMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TWeakObjectPtr<USceneComponent>, int> result;
				if ((result = this._InstanceMap) == null)
				{
					result = (this._InstanceMap = new TMap<TWeakObjectPtr<USceneComponent>, int>(base.NativePtr + (IntPtr)FBatchKeyInfo.__PropertyOffset_InstanceMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.InstanceMap.CopyAssign(value);
			}
		}

		// Token: 0x06016C6B RID: 93291 RVA: 0x00213CF1 File Offset: 0x00211EF1
		public FBatchKeyInfo()
		{
		}

		// Token: 0x06016C6C RID: 93292 RVA: 0x00213CF9 File Offset: 0x00211EF9
		[NullableContext(1)]
		public FBatchKeyInfo(UStaticMesh Mesh, UMaterialInterface Material, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TWeakObjectPtr<USceneComponent>, int> InstanceMap)
		{
			this.Mesh = Mesh;
			this.Material = Material;
			this.InstanceMap = InstanceMap;
		}

		// Token: 0x06016C6D RID: 93293 RVA: 0x00213D16 File Offset: 0x00211F16
		protected override IntPtr GetUStructPtr()
		{
			return FBatchKeyInfo.StaticStruct();
		}

		// Token: 0x06016C6E RID: 93294 RVA: 0x00213D22 File Offset: 0x00211F22
		public FBatchKeyInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016C6F RID: 93295 RVA: 0x00213D2C File Offset: 0x00211F2C
		public FBatchKeyInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016C70 RID: 93296 RVA: 0x00213D37 File Offset: 0x00211F37
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBatchKeyInfo(Pointer, false, true);
		}

		// Token: 0x06016C71 RID: 93297 RVA: 0x00213D41 File Offset: 0x00211F41
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBatchKeyInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400C5B8 RID: 50616
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroDynamicMeshBatch.BatchKeyInfo";

		// Token: 0x0400C5B9 RID: 50617
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C5BA RID: 50618
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400C5BB RID: 50619
		internal static int __PropertyOffset_Material;

		// Token: 0x0400C5BC RID: 50620
		internal static int __PropertyOffset_InstanceMap;

		// Token: 0x0400C5BD RID: 50621
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TWeakObjectPtr<USceneComponent>, int> _InstanceMap;
	}
}
