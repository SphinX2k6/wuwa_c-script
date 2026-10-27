using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200125F RID: 4703
	[UnrealObjectPath("/Script/Engine.WorldPartitionHLODSourceActors")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UWorldPartitionHLODSourceActors : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011448 RID: 70728 RVA: 0x00195966 File Offset: 0x00193B66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionHLODSourceActors._ClassPtr;
		}

		// Token: 0x06011449 RID: 70729 RVA: 0x00195972 File Offset: 0x00193B72
		static UWorldPartitionHLODSourceActors()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionHLODSourceActors");
		}

		// Token: 0x0601144A RID: 70730 RVA: 0x00195980 File Offset: 0x00193B80
		protected UWorldPartitionHLODSourceActors() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionHLODSourceActors.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601144B RID: 70731 RVA: 0x001959A8 File Offset: 0x00193BA8
		protected UWorldPartitionHLODSourceActors(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093D3 RID: 37843
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionHLODSourceActors";

		// Token: 0x040093D4 RID: 37844
		private static IntPtr _ClassPtr;

		// Token: 0x040093D5 RID: 37845
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
