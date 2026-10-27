using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BE6 RID: 3046
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FontImportOptions")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UFontImportOptions : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060095FA RID: 38394 RVA: 0x000D5D06 File Offset: 0x000D3F06
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFontImportOptions._ClassPtr;
		}

		// Token: 0x060095FB RID: 38395 RVA: 0x000D5D14 File Offset: 0x000D3F14
		public UFontImportOptions() : this(BuiltinUtils.AllocNativeUObject(UFontImportOptions.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060095FC RID: 38396 RVA: 0x000D5D3C File Offset: 0x000D3F3C
		public UFontImportOptions(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFontImportOptions.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x060095FD RID: 38397 RVA: 0x000D5D70 File Offset: 0x000D3F70
		// (set) Token: 0x060095FE RID: 38398 RVA: 0x000D5DA9 File Offset: 0x000D3FA9
		public FFontImportOptionsData Data
		{
			get
			{
				base.FastCheckIsValid();
				FFontImportOptionsData result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new FFontImportOptionsData(base.NativePtr + (IntPtr)UFontImportOptions.__PropertyOffset_Data, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFontImportOptionsData.StaticStruct(), base.NativePtr + (IntPtr)UFontImportOptions.__PropertyOffset_Data, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060095FF RID: 38399 RVA: 0x000D5DCA File Offset: 0x000D3FCA
		static UFontImportOptions()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.FontImportOptions");
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x000D5DD8 File Offset: 0x000D3FD8
		protected UFontImportOptions(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005421 RID: 21537
		public new const string __ObjectPath = "/Script/Engine.FontImportOptions";

		// Token: 0x04005422 RID: 21538
		private static IntPtr _ClassPtr;

		// Token: 0x04005423 RID: 21539
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005424 RID: 21540
		internal static int __PropertyOffset_Data;

		// Token: 0x04005425 RID: 21541
		[Nullable(2)]
		private FFontImportOptionsData _Data;
	}
}
