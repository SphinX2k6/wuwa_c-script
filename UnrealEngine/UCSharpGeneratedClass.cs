using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002756 RID: 10070
	[UnrealObjectPath("/Script/Sharphereal.CSharpGeneratedClass")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class UCSharpGeneratedClass : UBlueprintGeneratedClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025A59 RID: 154201 RVA: 0x00390EA1 File Offset: 0x0038F0A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCSharpGeneratedClass._ClassPtr;
		}

		// Token: 0x06025A5A RID: 154202 RVA: 0x00390EB0 File Offset: 0x0038F0B0
		public UCSharpGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(UCSharpGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025A5B RID: 154203 RVA: 0x00390ED8 File Offset: 0x0038F0D8
		[NullableContext(1)]
		public UCSharpGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCSharpGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025A5C RID: 154204 RVA: 0x00390F0B File Offset: 0x0038F10B
		static UCSharpGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Sharphereal.CSharpGeneratedClass");
		}

		// Token: 0x06025A5D RID: 154205 RVA: 0x00390F19 File Offset: 0x0038F119
		protected UCSharpGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014742 RID: 83778
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Sharphereal.CSharpGeneratedClass";

		// Token: 0x04014743 RID: 83779
		private static IntPtr _ClassPtr;

		// Token: 0x04014744 RID: 83780
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
