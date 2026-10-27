using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AB6 RID: 6838
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBookPavingActor")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AKuroBookPavingActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019601 RID: 103937 RVA: 0x00257EBA File Offset: 0x002560BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBookPavingActor._ClassPtr;
		}

		// Token: 0x06019602 RID: 103938 RVA: 0x00257EC8 File Offset: 0x002560C8
		public AKuroBookPavingActor() : this(BuiltinUtils.AllocNativeUObject(AKuroBookPavingActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019603 RID: 103939 RVA: 0x00257EF0 File Offset: 0x002560F0
		public AKuroBookPavingActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBookPavingActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700654E RID: 25934
		// (get) Token: 0x06019604 RID: 103940 RVA: 0x00257F24 File Offset: 0x00256124
		// (set) Token: 0x06019605 RID: 103941 RVA: 0x00257F5D File Offset: 0x0025615D
		public TArray<FBookPavingDataStruct> DataList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBookPavingDataStruct> result;
				if ((result = this._DataList) == null)
				{
					result = (this._DataList = new TArray<FBookPavingDataStruct>(base.NativePtr + (IntPtr)AKuroBookPavingActor.__PropertyOffset_DataList, this));
				}
				return result;
			}
			set
			{
				this.DataList.CopyAssign(value);
			}
		}

		// Token: 0x06019606 RID: 103942 RVA: 0x00257F6B File Offset: 0x0025616B
		static AKuroBookPavingActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBookPavingActor");
		}

		// Token: 0x06019607 RID: 103943 RVA: 0x00257F79 File Offset: 0x00256179
		protected AKuroBookPavingActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DD3C RID: 56636
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBookPavingActor";

		// Token: 0x0400DD3D RID: 56637
		private static IntPtr _ClassPtr;

		// Token: 0x0400DD3E RID: 56638
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DD3F RID: 56639
		internal static int __PropertyOffset_DataList;

		// Token: 0x0400DD40 RID: 56640
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBookPavingDataStruct> _DataList;
	}
}
