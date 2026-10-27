using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002550 RID: 9552
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelHandler_Placement")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UNiagaraDataChannelHandler_Placement : UNiagaraDataChannelHandler, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060237CE RID: 145358 RVA: 0x00347636 File Offset: 0x00345836
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelHandler_Placement._ClassPtr;
		}

		// Token: 0x060237CF RID: 145359 RVA: 0x00347644 File Offset: 0x00345844
		public UNiagaraDataChannelHandler_Placement() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelHandler_Placement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060237D0 RID: 145360 RVA: 0x0034766C File Offset: 0x0034586C
		[NullableContext(1)]
		public UNiagaraDataChannelHandler_Placement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelHandler_Placement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700884B RID: 34891
		// (get) Token: 0x060237D1 RID: 145361 RVA: 0x003476A0 File Offset: 0x003458A0
		// (set) Token: 0x060237D2 RID: 145362 RVA: 0x003476D9 File Offset: 0x003458D9
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TWeakObjectPtr<USceneComponent>, FNDCPlacement> NDCPlacementMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TWeakObjectPtr<USceneComponent>, FNDCPlacement> result;
				if ((result = this._NDCPlacementMap) == null)
				{
					result = (this._NDCPlacementMap = new TMap<TWeakObjectPtr<USceneComponent>, FNDCPlacement>(base.NativePtr + (IntPtr)UNiagaraDataChannelHandler_Placement.__PropertyOffset_NDCPlacementMap, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.NDCPlacementMap.CopyAssign(value);
			}
		}

		// Token: 0x060237D3 RID: 145363 RVA: 0x003476E7 File Offset: 0x003458E7
		static UNiagaraDataChannelHandler_Placement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelHandler_Placement");
		}

		// Token: 0x060237D4 RID: 145364 RVA: 0x003476F5 File Offset: 0x003458F5
		protected UNiagaraDataChannelHandler_Placement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401307B RID: 77947
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelHandler_Placement";

		// Token: 0x0401307C RID: 77948
		private static IntPtr _ClassPtr;

		// Token: 0x0401307D RID: 77949
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401307E RID: 77950
		internal static int __PropertyOffset_NDCPlacementMap;

		// Token: 0x0401307F RID: 77951
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TWeakObjectPtr<USceneComponent>, FNDCPlacement> _NDCPlacementMap;
	}
}
