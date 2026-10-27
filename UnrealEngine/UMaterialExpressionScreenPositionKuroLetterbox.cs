using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E3A RID: 3642
	[UnrealObjectPath("/Script/Engine.MaterialExpressionScreenPositionKuroLetterbox")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionScreenPositionKuroLetterbox : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C3B4 RID: 50100 RVA: 0x0011AA4A File Offset: 0x00118C4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionScreenPositionKuroLetterbox._ClassPtr;
		}

		// Token: 0x0600C3B5 RID: 50101 RVA: 0x0011AA58 File Offset: 0x00118C58
		public UMaterialExpressionScreenPositionKuroLetterbox() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionScreenPositionKuroLetterbox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C3B6 RID: 50102 RVA: 0x0011AA80 File Offset: 0x00118C80
		[NullableContext(1)]
		public UMaterialExpressionScreenPositionKuroLetterbox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionScreenPositionKuroLetterbox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C3B7 RID: 50103 RVA: 0x0011AAB3 File Offset: 0x00118CB3
		static UMaterialExpressionScreenPositionKuroLetterbox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionScreenPositionKuroLetterbox");
		}

		// Token: 0x0600C3B8 RID: 50104 RVA: 0x0011AAC1 File Offset: 0x00118CC1
		protected UMaterialExpressionScreenPositionKuroLetterbox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400685F RID: 26719
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionScreenPositionKuroLetterbox";

		// Token: 0x04006860 RID: 26720
		private static IntPtr _ClassPtr;

		// Token: 0x04006861 RID: 26721
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
