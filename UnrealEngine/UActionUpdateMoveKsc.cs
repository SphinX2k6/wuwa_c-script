using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200171B RID: 5915
	[UnrealObjectPath("/Script/KuroBullet.ActionUpdateMoveKsc")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionUpdateMoveKsc : UActionUpdateMove, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015531 RID: 87345 RVA: 0x001F57DE File Offset: 0x001F39DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionUpdateMoveKsc._ClassPtr;
		}

		// Token: 0x06015532 RID: 87346 RVA: 0x001F57EC File Offset: 0x001F39EC
		public UActionUpdateMoveKsc() : this(BuiltinUtils.AllocNativeUObject(UActionUpdateMoveKsc.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015533 RID: 87347 RVA: 0x001F5814 File Offset: 0x001F3A14
		[NullableContext(1)]
		public UActionUpdateMoveKsc(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionUpdateMoveKsc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015534 RID: 87348 RVA: 0x001F5847 File Offset: 0x001F3A47
		static UActionUpdateMoveKsc()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.ActionUpdateMoveKsc");
		}

		// Token: 0x06015535 RID: 87349 RVA: 0x001F5855 File Offset: 0x001F3A55
		protected UActionUpdateMoveKsc(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9F9 RID: 47609
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.ActionUpdateMoveKsc";

		// Token: 0x0400B9FA RID: 47610
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9FB RID: 47611
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
