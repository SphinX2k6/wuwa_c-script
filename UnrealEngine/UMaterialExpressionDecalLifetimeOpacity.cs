using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DB0 RID: 3504
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDecalLifetimeOpacity")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionDecalLifetimeOpacity : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE8A RID: 48778 RVA: 0x00110EAA File Offset: 0x0010F0AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDecalLifetimeOpacity._ClassPtr;
		}

		// Token: 0x0600BE8B RID: 48779 RVA: 0x00110EB8 File Offset: 0x0010F0B8
		public UMaterialExpressionDecalLifetimeOpacity() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDecalLifetimeOpacity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE8C RID: 48780 RVA: 0x00110EE0 File Offset: 0x0010F0E0
		[NullableContext(1)]
		public UMaterialExpressionDecalLifetimeOpacity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDecalLifetimeOpacity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BE8D RID: 48781 RVA: 0x00110F13 File Offset: 0x0010F113
		static UMaterialExpressionDecalLifetimeOpacity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDecalLifetimeOpacity");
		}

		// Token: 0x0600BE8E RID: 48782 RVA: 0x00110F21 File Offset: 0x0010F121
		protected UMaterialExpressionDecalLifetimeOpacity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064BC RID: 25788
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDecalLifetimeOpacity";

		// Token: 0x040064BD RID: 25789
		private static IntPtr _ClassPtr;

		// Token: 0x040064BE RID: 25790
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
