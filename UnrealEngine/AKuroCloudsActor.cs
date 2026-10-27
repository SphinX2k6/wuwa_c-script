using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AD1 RID: 6865
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCloudsActor")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class AKuroCloudsActor : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019916 RID: 104726 RVA: 0x0025CCB7 File Offset: 0x0025AEB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCloudsActor._ClassPtr;
		}

		// Token: 0x06019917 RID: 104727 RVA: 0x0025CCC4 File Offset: 0x0025AEC4
		public AKuroCloudsActor() : this(BuiltinUtils.AllocNativeUObject(AKuroCloudsActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019918 RID: 104728 RVA: 0x0025CCEC File Offset: 0x0025AEEC
		[NullableContext(1)]
		public AKuroCloudsActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCloudsActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06019919 RID: 104729 RVA: 0x0025CD20 File Offset: 0x0025AF20
		[NullableContext(2)]
		public void GetGIParams(bool bCounting, UChildActorComponent Child01, UChildActorComponent Child02, UMaterialParameterCollection CloudCardCollection, FName ParameterName, float CurrentTime)
		{
			AKuroCloudsActor.__GetGIParams_Internal(base.NativePtr, bCounting, (Child01 != null) ? Child01.NativePtr : IntPtr.Zero, (Child02 != null) ? Child02.NativePtr : IntPtr.Zero, (CloudCardCollection != null) ? CloudCardCollection.NativePtr : IntPtr.Zero, ParameterName, CurrentTime);
		}

		// Token: 0x0601991A RID: 104730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetGIParams_Internal(IntPtr @this, bool bCounting, IntPtr Child01, IntPtr Child02, IntPtr CloudCardCollection, FName ParameterName, float CurrentTime);

		// Token: 0x0601991B RID: 104731 RVA: 0x0025CD6F File Offset: 0x0025AF6F
		static AKuroCloudsActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCloudsActor");
		}

		// Token: 0x0601991C RID: 104732 RVA: 0x0025CD7D File Offset: 0x0025AF7D
		protected AKuroCloudsActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DEBC RID: 57020
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCloudsActor";

		// Token: 0x0400DEBD RID: 57021
		private static IntPtr _ClassPtr;

		// Token: 0x0400DEBE RID: 57022
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
