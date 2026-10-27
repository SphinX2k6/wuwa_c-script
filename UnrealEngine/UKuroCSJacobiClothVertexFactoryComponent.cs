using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017B3 RID: 6067
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSJacobiClothVertexFactoryComponent")]
	[UnrealStructLayout(1584, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class UKuroCSJacobiClothVertexFactoryComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601612C RID: 90412 RVA: 0x00205698 File Offset: 0x00203898
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCSJacobiClothVertexFactoryComponent._ClassPtr;
		}

		// Token: 0x0601612D RID: 90413 RVA: 0x002056A4 File Offset: 0x002038A4
		public UKuroCSJacobiClothVertexFactoryComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCSJacobiClothVertexFactoryComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601612E RID: 90414 RVA: 0x002056CC File Offset: 0x002038CC
		[NullableContext(1)]
		public UKuroCSJacobiClothVertexFactoryComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCSJacobiClothVertexFactoryComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601612F RID: 90415 RVA: 0x002056FF File Offset: 0x002038FF
		static UKuroCSJacobiClothVertexFactoryComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSJacobiClothVertexFactoryComponent");
		}

		// Token: 0x06016130 RID: 90416 RVA: 0x0020570D File Offset: 0x0020390D
		protected UKuroCSJacobiClothVertexFactoryComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C05B RID: 49243
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSJacobiClothVertexFactoryComponent";

		// Token: 0x0400C05C RID: 49244
		private static IntPtr _ClassPtr;

		// Token: 0x0400C05D RID: 49245
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
