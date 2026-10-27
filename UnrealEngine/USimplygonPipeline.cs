using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027DD RID: 10205
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonPipeline")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class USimplygonPipeline : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260D6 RID: 155862 RVA: 0x0039B7E5 File Offset: 0x003999E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonPipeline._ClassPtr;
		}

		// Token: 0x170092D9 RID: 37593
		// (get) Token: 0x060260D7 RID: 155863 RVA: 0x0039B7F1 File Offset: 0x003999F1
		// (set) Token: 0x060260D8 RID: 155864 RVA: 0x0039B801 File Offset: 0x00399A01
		public unsafe int BaseLODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USimplygonPipeline.__PropertyOffset_BaseLODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USimplygonPipeline.__PropertyOffset_BaseLODIndex) = value;
			}
		}

		// Token: 0x060260D9 RID: 155865 RVA: 0x0039B812 File Offset: 0x00399A12
		static USimplygonPipeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SimplygonPipeline");
		}

		// Token: 0x060260DA RID: 155866 RVA: 0x0039B820 File Offset: 0x00399A20
		protected USimplygonPipeline() : this(BuiltinUtils.AllocNativeUObject(USimplygonPipeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260DB RID: 155867 RVA: 0x0039B848 File Offset: 0x00399A48
		protected USimplygonPipeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C78 RID: 85112
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonPipeline";

		// Token: 0x04014C79 RID: 85113
		private static IntPtr _ClassPtr;

		// Token: 0x04014C7A RID: 85114
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014C7B RID: 85115
		internal static int __PropertyOffset_BaseLODIndex;
	}
}
