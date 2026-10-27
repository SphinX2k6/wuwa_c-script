using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B5 RID: 693
	[UnrealObjectPath("/Script/AnimationCore.AnimationDataSourceRegistry")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UAnimationDataSourceRegistry : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060026A4 RID: 9892 RVA: 0x0003A1FB File Offset: 0x000383FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimationDataSourceRegistry._ClassPtr;
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x0003A208 File Offset: 0x00038408
		public UAnimationDataSourceRegistry() : this(BuiltinUtils.AllocNativeUObject(UAnimationDataSourceRegistry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x0003A230 File Offset: 0x00038430
		[NullableContext(1)]
		public UAnimationDataSourceRegistry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimationDataSourceRegistry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x0003A264 File Offset: 0x00038464
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x0003A29D File Offset: 0x0003849D
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<FName, TWeakObjectPtr<UObject>> DataSources
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, TWeakObjectPtr<UObject>> result;
				if ((result = this._DataSources) == null)
				{
					result = (this._DataSources = new TMap<FName, TWeakObjectPtr<UObject>>(base.NativePtr + (IntPtr)UAnimationDataSourceRegistry.__PropertyOffset_DataSources, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.DataSources.CopyAssign(value);
			}
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x0003A2AB File Offset: 0x000384AB
		static UAnimationDataSourceRegistry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AnimationCore.AnimationDataSourceRegistry");
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x0003A2B9 File Offset: 0x000384B9
		protected UAnimationDataSourceRegistry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000F2D RID: 3885
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimationCore.AnimationDataSourceRegistry";

		// Token: 0x04000F2E RID: 3886
		private static IntPtr _ClassPtr;

		// Token: 0x04000F2F RID: 3887
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000F30 RID: 3888
		internal static int __PropertyOffset_DataSources;

		// Token: 0x04000F31 RID: 3889
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<FName, TWeakObjectPtr<UObject>> _DataSources;
	}
}
