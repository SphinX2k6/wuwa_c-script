using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027D7 RID: 10199
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonComputeCaster")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USimplygonComputeCaster : USimplygonMaterialCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260AF RID: 155823 RVA: 0x0039B34D File Offset: 0x0039954D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonComputeCaster._ClassPtr;
		}

		// Token: 0x060260B0 RID: 155824 RVA: 0x0039B35C File Offset: 0x0039955C
		public USimplygonComputeCaster() : this(BuiltinUtils.AllocNativeUObject(USimplygonComputeCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260B1 RID: 155825 RVA: 0x0039B384 File Offset: 0x00399584
		public USimplygonComputeCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimplygonComputeCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170092D4 RID: 37588
		// (get) Token: 0x060260B2 RID: 155826 RVA: 0x0039B3B8 File Offset: 0x003995B8
		// (set) Token: 0x060260B3 RID: 155827 RVA: 0x0039B3F1 File Offset: 0x003995F1
		public FComputeCasterSettings ComputeCasterSettings
		{
			get
			{
				base.FastCheckIsValid();
				FComputeCasterSettings result;
				if ((result = this._ComputeCasterSettings) == null)
				{
					result = (this._ComputeCasterSettings = new FComputeCasterSettings(base.NativePtr + (IntPtr)USimplygonComputeCaster.__PropertyOffset_ComputeCasterSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComputeCasterSettings.StaticStruct(), base.NativePtr + (IntPtr)USimplygonComputeCaster.__PropertyOffset_ComputeCasterSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060260B4 RID: 155828 RVA: 0x0039B412 File Offset: 0x00399612
		static USimplygonComputeCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SimplygonComputeCaster");
		}

		// Token: 0x060260B5 RID: 155829 RVA: 0x0039B420 File Offset: 0x00399620
		protected USimplygonComputeCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C5C RID: 85084
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonComputeCaster";

		// Token: 0x04014C5D RID: 85085
		private static IntPtr _ClassPtr;

		// Token: 0x04014C5E RID: 85086
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014C5F RID: 85087
		internal static int __PropertyOffset_ComputeCasterSettings;

		// Token: 0x04014C60 RID: 85088
		[Nullable(2)]
		private FComputeCasterSettings _ComputeCasterSettings;
	}
}
