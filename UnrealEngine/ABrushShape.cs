using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008F8 RID: 2296
	[UnrealObjectPath("/Script/Engine.BrushShape")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ABrushShape : ABrush, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E01 RID: 32257 RVA: 0x000B499C File Offset: 0x000B2B9C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABrushShape._ClassPtr;
		}

		// Token: 0x06007E02 RID: 32258 RVA: 0x000B49A8 File Offset: 0x000B2BA8
		public ABrushShape() : this(BuiltinUtils.AllocNativeUObject(ABrushShape.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E03 RID: 32259 RVA: 0x000B49D0 File Offset: 0x000B2BD0
		[NullableContext(1)]
		public ABrushShape(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABrushShape.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007E04 RID: 32260 RVA: 0x000B4A03 File Offset: 0x000B2C03
		static ABrushShape()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BrushShape");
		}

		// Token: 0x06007E05 RID: 32261 RVA: 0x000B4A11 File Offset: 0x000B2C11
		protected ABrushShape(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003C6A RID: 15466
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BrushShape";

		// Token: 0x04003C6B RID: 15467
		private static IntPtr _ClassPtr;

		// Token: 0x04003C6C RID: 15468
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
