using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D82 RID: 3458
	[UnrealObjectPath("/Script/Engine.MaterialExpressionAntialiasedTextureMask")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class UMaterialExpressionAntialiasedTextureMask : UMaterialExpressionTextureSampleParameter2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BCFA RID: 48378 RVA: 0x0010E1AB File Offset: 0x0010C3AB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionAntialiasedTextureMask._ClassPtr;
		}

		// Token: 0x0600BCFB RID: 48379 RVA: 0x0010E1B8 File Offset: 0x0010C3B8
		public UMaterialExpressionAntialiasedTextureMask() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAntialiasedTextureMask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BCFC RID: 48380 RVA: 0x0010E1E0 File Offset: 0x0010C3E0
		[NullableContext(1)]
		public UMaterialExpressionAntialiasedTextureMask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAntialiasedTextureMask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x0600BCFD RID: 48381 RVA: 0x0010E213 File Offset: 0x0010C413
		// (set) Token: 0x0600BCFE RID: 48382 RVA: 0x0010E223 File Offset: 0x0010C423
		public unsafe float Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionAntialiasedTextureMask.__PropertyOffset_Threshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionAntialiasedTextureMask.__PropertyOffset_Threshold) = value;
			}
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x0600BCFF RID: 48383 RVA: 0x0010E234 File Offset: 0x0010C434
		// (set) Token: 0x0600BD00 RID: 48384 RVA: 0x0010E248 File Offset: 0x0010C448
		public unsafe TEnumAsByte<ETextureColorChannel> Channel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionAntialiasedTextureMask.__PropertyOffset_Channel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionAntialiasedTextureMask.__PropertyOffset_Channel) = value;
			}
		}

		// Token: 0x0600BD01 RID: 48385 RVA: 0x0010E25D File Offset: 0x0010C45D
		static UMaterialExpressionAntialiasedTextureMask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionAntialiasedTextureMask");
		}

		// Token: 0x0600BD02 RID: 48386 RVA: 0x0010E26B File Offset: 0x0010C46B
		protected UMaterialExpressionAntialiasedTextureMask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063A9 RID: 25513
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionAntialiasedTextureMask";

		// Token: 0x040063AA RID: 25514
		private static IntPtr _ClassPtr;

		// Token: 0x040063AB RID: 25515
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063AC RID: 25516
		internal static int __PropertyOffset_Threshold;

		// Token: 0x040063AD RID: 25517
		internal static int __PropertyOffset_Channel;
	}
}
