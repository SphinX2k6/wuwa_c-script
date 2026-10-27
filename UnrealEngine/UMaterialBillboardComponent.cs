using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D79 RID: 3449
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialBillboardComponent")]
	[UnrealStructLayout(1584, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class UMaterialBillboardComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BC78 RID: 48248 RVA: 0x0010D19C File Offset: 0x0010B39C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialBillboardComponent._ClassPtr;
		}

		// Token: 0x0600BC79 RID: 48249 RVA: 0x0010D1A8 File Offset: 0x0010B3A8
		public UMaterialBillboardComponent() : this(BuiltinUtils.AllocNativeUObject(UMaterialBillboardComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BC7A RID: 48250 RVA: 0x0010D1D0 File Offset: 0x0010B3D0
		public UMaterialBillboardComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialBillboardComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x0600BC7B RID: 48251 RVA: 0x0010D204 File Offset: 0x0010B404
		// (set) Token: 0x0600BC7C RID: 48252 RVA: 0x0010D23D File Offset: 0x0010B43D
		public TArray<FMaterialSpriteElement> Elements
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMaterialSpriteElement> result;
				if ((result = this._Elements) == null)
				{
					result = (this._Elements = new TArray<FMaterialSpriteElement>(base.NativePtr + (IntPtr)UMaterialBillboardComponent.__PropertyOffset_Elements, this));
				}
				return result;
			}
			set
			{
				this.Elements.CopyAssign(value);
			}
		}

		// Token: 0x0600BC7D RID: 48253 RVA: 0x0010D24B File Offset: 0x0010B44B
		public void SetElements([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FMaterialSpriteElement> NewElements)
		{
			UMaterialBillboardComponent.__SetElements_Internal(base.NativePtr, (NewElements ?? new TArray<FMaterialSpriteElement>()).NativePtr);
		}

		// Token: 0x0600BC7E RID: 48254 RVA: 0x0010D268 File Offset: 0x0010B468
		[NullableContext(2)]
		public void AddElement(UMaterialInterface Material, UCurveFloat DistanceToOpacityCurve, bool bSizeIsInScreenSpace, float BaseSizeX, float BaseSizeY, UCurveFloat DistanceToSizeCurve)
		{
			UMaterialBillboardComponent.__AddElement_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero, (DistanceToOpacityCurve != null) ? DistanceToOpacityCurve.NativePtr : IntPtr.Zero, bSizeIsInScreenSpace, BaseSizeX, BaseSizeY, (DistanceToSizeCurve != null) ? DistanceToSizeCurve.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BC7F RID: 48255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetElements_Internal(IntPtr @this, IntPtr NewElements);

		// Token: 0x0600BC80 RID: 48256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddElement_Internal(IntPtr @this, IntPtr Material, IntPtr DistanceToOpacityCurve, bool bSizeIsInScreenSpace, float BaseSizeX, float BaseSizeY, IntPtr DistanceToSizeCurve);

		// Token: 0x0600BC81 RID: 48257 RVA: 0x0010D2B7 File Offset: 0x0010B4B7
		static UMaterialBillboardComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialBillboardComponent");
		}

		// Token: 0x0600BC82 RID: 48258 RVA: 0x0010D2C5 File Offset: 0x0010B4C5
		protected UMaterialBillboardComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006350 RID: 25424
		public new const string __ObjectPath = "/Script/Engine.MaterialBillboardComponent";

		// Token: 0x04006351 RID: 25425
		private static IntPtr _ClassPtr;

		// Token: 0x04006352 RID: 25426
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006353 RID: 25427
		internal static int __PropertyOffset_Elements;

		// Token: 0x04006354 RID: 25428
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMaterialSpriteElement> _Elements;
	}
}
