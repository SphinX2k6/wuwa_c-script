using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027CE RID: 10190
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.RemeshingPipeline")]
	[UnrealStructLayout(616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 616)]
	public class URemeshingPipeline : USimplygonPipeline, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026025 RID: 155685 RVA: 0x0039A414 File Offset: 0x00398614
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URemeshingPipeline._ClassPtr;
		}

		// Token: 0x06026026 RID: 155686 RVA: 0x0039A420 File Offset: 0x00398620
		public URemeshingPipeline() : this(BuiltinUtils.AllocNativeUObject(URemeshingPipeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026027 RID: 155687 RVA: 0x0039A448 File Offset: 0x00398648
		public URemeshingPipeline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URemeshingPipeline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170092AA RID: 37546
		// (get) Token: 0x06026028 RID: 155688 RVA: 0x0039A47C File Offset: 0x0039867C
		// (set) Token: 0x06026029 RID: 155689 RVA: 0x0039A4B5 File Offset: 0x003986B5
		public FRemeshingPipelineSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FRemeshingPipelineSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FRemeshingPipelineSettings(base.NativePtr + (IntPtr)URemeshingPipeline.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRemeshingPipelineSettings.StaticStruct(), base.NativePtr + (IntPtr)URemeshingPipeline.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602602A RID: 155690 RVA: 0x0039A4D6 File Offset: 0x003986D6
		static URemeshingPipeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.RemeshingPipeline");
		}

		// Token: 0x0602602B RID: 155691 RVA: 0x0039A4E4 File Offset: 0x003986E4
		protected URemeshingPipeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C04 RID: 84996
		public new const string __ObjectPath = "/Script/SimplygonUObjects.RemeshingPipeline";

		// Token: 0x04014C05 RID: 84997
		private static IntPtr _ClassPtr;

		// Token: 0x04014C06 RID: 84998
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014C07 RID: 84999
		internal static int __PropertyOffset_Settings;

		// Token: 0x04014C08 RID: 85000
		[Nullable(2)]
		private FRemeshingPipelineSettings _Settings;
	}
}
