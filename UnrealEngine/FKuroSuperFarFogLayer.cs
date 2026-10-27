using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BCE RID: 7118
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSuperFarFogLayer")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroSuperFarFogLayer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B50A RID: 111882 RVA: 0x00283EAD File Offset: 0x002820AD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSuperFarFogLayer._ScriptStructPtr != 0) ? FKuroSuperFarFogLayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSuperFarFogLayer", ref FKuroSuperFarFogLayer._ScriptStructPtr);
		}

		// Token: 0x17006DBE RID: 28094
		// (get) Token: 0x0601B50B RID: 111883 RVA: 0x00283ED1 File Offset: 0x002820D1
		// (set) Token: 0x0601B50C RID: 111884 RVA: 0x00283EE1 File Offset: 0x002820E1
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSuperFarFogLayer.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSuperFarFogLayer.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x17006DBF RID: 28095
		// (get) Token: 0x0601B50D RID: 111885 RVA: 0x00283EF2 File Offset: 0x002820F2
		// (set) Token: 0x0601B50E RID: 111886 RVA: 0x00283F06 File Offset: 0x00282106
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSuperFarFogLayer.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSuperFarFogLayer.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x17006DC0 RID: 28096
		// (get) Token: 0x0601B50F RID: 111887 RVA: 0x00283F1C File Offset: 0x0028211C
		// (set) Token: 0x0601B510 RID: 111888 RVA: 0x00283F5F File Offset: 0x0028215F
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FKuroSuperFarFogLayer.__PropertyOffset_Materials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x0601B511 RID: 111889 RVA: 0x00283F6D File Offset: 0x0028216D
		public FKuroSuperFarFogLayer()
		{
		}

		// Token: 0x0601B512 RID: 111890 RVA: 0x00283F75 File Offset: 0x00282175
		public FKuroSuperFarFogLayer(float Distance, UStaticMesh StaticMesh, TArray<UMaterialInterface> Materials)
		{
			this.Distance = Distance;
			this.StaticMesh = StaticMesh;
			this.Materials = Materials;
		}

		// Token: 0x0601B513 RID: 111891 RVA: 0x00283F92 File Offset: 0x00282192
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSuperFarFogLayer.StaticStruct();
		}

		// Token: 0x0601B514 RID: 111892 RVA: 0x00283F9E File Offset: 0x0028219E
		[NullableContext(2)]
		public FKuroSuperFarFogLayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B515 RID: 111893 RVA: 0x00283FA8 File Offset: 0x002821A8
		public FKuroSuperFarFogLayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B516 RID: 111894 RVA: 0x00283FB3 File Offset: 0x002821B3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSuperFarFogLayer(Pointer, false, true);
		}

		// Token: 0x0601B517 RID: 111895 RVA: 0x00283FBD File Offset: 0x002821BD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSuperFarFogLayer(Pointer, MemoryOwner);
		}

		// Token: 0x0400EB54 RID: 60244
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSuperFarFogLayer";

		// Token: 0x0400EB55 RID: 60245
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EB56 RID: 60246
		internal static int __PropertyOffset_Distance;

		// Token: 0x0400EB57 RID: 60247
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400EB58 RID: 60248
		internal static int __PropertyOffset_Materials;

		// Token: 0x0400EB59 RID: 60249
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;
	}
}
