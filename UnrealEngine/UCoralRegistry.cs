using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A62 RID: 6754
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CoralRegistry")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UCoralRegistry : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019016 RID: 102422 RVA: 0x0024F4C4 File Offset: 0x0024D6C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCoralRegistry._ClassPtr;
		}

		// Token: 0x06019017 RID: 102423 RVA: 0x0024F4D0 File Offset: 0x0024D6D0
		public UCoralRegistry() : this(BuiltinUtils.AllocNativeUObject(UCoralRegistry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019018 RID: 102424 RVA: 0x0024F4F8 File Offset: 0x0024D6F8
		public UCoralRegistry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCoralRegistry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006321 RID: 25377
		// (get) Token: 0x06019019 RID: 102425 RVA: 0x0024F52C File Offset: 0x0024D72C
		// (set) Token: 0x0601901A RID: 102426 RVA: 0x0024F565 File Offset: 0x0024D765
		public TArray<FCoralMeshEntry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCoralMeshEntry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FCoralMeshEntry>(base.NativePtr + (IntPtr)UCoralRegistry.__PropertyOffset_Entries, this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x0601901B RID: 102427 RVA: 0x0024F573 File Offset: 0x0024D773
		static UCoralRegistry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.CoralRegistry");
		}

		// Token: 0x0601901C RID: 102428 RVA: 0x0024F581 File Offset: 0x0024D781
		protected UCoralRegistry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D86E RID: 55406
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CoralRegistry";

		// Token: 0x0400D86F RID: 55407
		private static IntPtr _ClassPtr;

		// Token: 0x0400D870 RID: 55408
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D871 RID: 55409
		internal static int __PropertyOffset_Entries;

		// Token: 0x0400D872 RID: 55410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCoralMeshEntry> _Entries;
	}
}
