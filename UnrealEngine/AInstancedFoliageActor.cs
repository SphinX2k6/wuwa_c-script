using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012CE RID: 4814
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.InstancedFoliageActor")]
	[UnrealStructLayout(1880, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1880)]
	public class AInstancedFoliageActor : AISMPartitionActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011A92 RID: 72338 RVA: 0x0019EBF3 File Offset: 0x0019CDF3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AInstancedFoliageActor._ClassPtr;
		}

		// Token: 0x06011A93 RID: 72339 RVA: 0x0019EC00 File Offset: 0x0019CE00
		public AInstancedFoliageActor() : this(BuiltinUtils.AllocNativeUObject(AInstancedFoliageActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011A94 RID: 72340 RVA: 0x0019EC28 File Offset: 0x0019CE28
		public AInstancedFoliageActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AInstancedFoliageActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700451F RID: 17695
		// (get) Token: 0x06011A95 RID: 72341 RVA: 0x0019EC5C File Offset: 0x0019CE5C
		// (set) Token: 0x06011A96 RID: 72342 RVA: 0x0019EC95 File Offset: 0x0019CE95
		public TArray<FPCGFoliageInstance> PCGFoliageInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPCGFoliageInstance> result;
				if ((result = this._PCGFoliageInstances) == null)
				{
					result = (this._PCGFoliageInstances = new TArray<FPCGFoliageInstance>(base.NativePtr + (IntPtr)AInstancedFoliageActor.__PropertyOffset_PCGFoliageInstances, this));
				}
				return result;
			}
			set
			{
				this.PCGFoliageInstances.CopyAssign(value);
			}
		}

		// Token: 0x17004520 RID: 17696
		// (get) Token: 0x06011A97 RID: 72343 RVA: 0x0019ECA3 File Offset: 0x0019CEA3
		// (set) Token: 0x06011A98 RID: 72344 RVA: 0x0019ECB3 File Offset: 0x0019CEB3
		public unsafe bool bInstanceTransformIsRelative
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AInstancedFoliageActor.__PropertyOffset_bInstanceTransformIsRelative) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AInstancedFoliageActor.__PropertyOffset_bInstanceTransformIsRelative) = (value ? 1 : 0);
			}
		}

		// Token: 0x06011A99 RID: 72345 RVA: 0x0019ECC4 File Offset: 0x0019CEC4
		static AInstancedFoliageActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.InstancedFoliageActor");
		}

		// Token: 0x06011A9A RID: 72346 RVA: 0x0019ECD2 File Offset: 0x0019CED2
		protected AInstancedFoliageActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009798 RID: 38808
		public new const string __ObjectPath = "/Script/Foliage.InstancedFoliageActor";

		// Token: 0x04009799 RID: 38809
		private static IntPtr _ClassPtr;

		// Token: 0x0400979A RID: 38810
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400979B RID: 38811
		internal static int __PropertyOffset_PCGFoliageInstances;

		// Token: 0x0400979C RID: 38812
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPCGFoliageInstance> _PCGFoliageInstances;

		// Token: 0x0400979D RID: 38813
		internal static int __PropertyOffset_bInstanceTransformIsRelative;
	}
}
